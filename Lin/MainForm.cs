using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _rescanPortNames_Click(sender, e);
            backgroundWorker1.RunWorkerAsync();
        }

        private void _rescanPortNames_Click(object sender, EventArgs e)
        {
            _portNames.Items.Clear();
            foreach (string name in SerialPort.GetPortNames())
            {
                _portNames.Items.Add(name);
            }
            if(StaticContainer.isTest)
            {
                _portNames.Items.Add("Test");
            }
            if (_portNames.Items.Count > 0)
            {
                _portNames.SelectedIndex = 0;
            }
        }

        private void _connect_Click(object sender, EventArgs e)
        {
            StaticContainer.port = PortFactory.GetPort((string)_portNames.SelectedItem);
            StaticContainer.port.Connect((int)_speed.Value);
        }

        private void _disconnect_Click(object sender, EventArgs e)
        {
            StaticContainer.port.Disconnect();
        }

        public delegate void InvokeDelegate(object value);
        public void InvokeTrace(object value)
        {
            if (_traceText.InvokeRequired)
            {
                _traceText.Invoke(new InvokeDelegate(InvokeTrace), value);
            }
            else
            {
                if (_isTrace.Checked)
                {
                    _traceText.Text = (string)value + "\r\n" + _traceText.Text;
                }
            }
        }

        public void InvokeMonitor(object value)
        {
            if (_monitorText.InvokeRequired)
            {
                _monitorText.Invoke(new InvokeDelegate(InvokeMonitor), value);
            }
            else
            {
                _monitorText.Text = (string)value;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                if (StaticContainer.port == null)
                {
                    Thread.Sleep(200);
                    continue;
                }
                if (!StaticContainer.port.IsOpen())
                {
                    Thread.Sleep(200);
                    continue;
                }
                
                Packet p = null;
                if (Packet.Parse(StaticContainer.port.Receive(), out p))
                {
                    if(StaticContainer.filter.Count > 0 && !StaticContainer.filter.Exists(x => x == p.Function))
                    {
                        continue;
                    }

                    foreach (PacketMonitorItem pm in StaticContainer.databuffer)
                    {
                        if (!StaticContainer.groupByFunc && pm.Packet.CompareByAll(p))
                        {
                            pm.Count++;
                            goto show;
                        }
                        if (StaticContainer.groupByFunc && pm.Packet.CompareByFunction(p))
                        {
                            pm.Packet = p;
                            pm.Count++;
                            goto show;
                        }
                    }

                    StaticContainer.databuffer.Add(new PacketMonitorItem
                    {
                        Packet = p,
                        Count = 1
                    });

                    show:
                    InvokeTrace(p.ToStringWithDate());

                    StringBuilder monitorText = new StringBuilder();
                    foreach (PacketMonitorItem pm in StaticContainer.databuffer)
                    {
                        monitorText.AppendLine(string.Format("{0} Count:{1}", pm.Packet.ToStringWithoutDate(), pm.Count));
                    }
                    InvokeMonitor(monitorText.ToString());
                }
            }
            while (true);
        }

        private void _clearmonitor_Click(object sender, EventArgs e)
        {
            StaticContainer.databuffer.Clear();
        }

        private void _cleartrace_Click(object sender, EventArgs e)
        {
            _traceText.Clear();
        }

        private void _groupByFunc_CheckedChanged(object sender, EventArgs e)
        {
            StaticContainer.groupByFunc = _groupByFunc.Checked;
        }

        private void _isFiltered_CheckedChanged(object sender, EventArgs e)
        {
            StaticContainer.filter.Clear();
            if (_isFiltered.Checked)
            {
                string[] items = _filter.Text.Split('|');
                foreach (string item in items)
                {
                    StaticContainer.filter.Add(byte.Parse(item, System.Globalization.NumberStyles.AllowHexSpecifier));
                }
            }
        }
    }
}
