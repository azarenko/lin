using System.Diagnostics;
using System.IO;
using System.IO.Ports;

namespace Lin
{
    class RealPort : IPort
    {
        private static SerialPort serial = new SerialPort();
        private static Stopwatch sw = new Stopwatch();
        public RealPort(string Name)
        {
            serial.PortName = Name;
            serial.DataBits = 8;
            serial.StopBits = StopBits.One;
            serial.Parity = Parity.None;
        }

        public void Connect(int speed)
        {
            serial.BaudRate = speed;
            serial.Open();
        }

        public void Disconnect()
        {
            serial.Close();
        }

        public byte Receive()
        {
            try
            {
                return (byte)serial.ReadByte();
            }
            catch (IOException)
            {
                return 0x00;
            }
        }

        public void Transmmit(byte[] buffer)
        {
            int bitTime = 1000000 / serial.BaudRate;
            serial.RtsEnable = true;
            Pause(bitTime * 13);
            serial.RtsEnable = false;
            serial.Write(new byte[] { 0x55 }, 0, 1);
            serial.Write(buffer, 0, buffer.Length);
        }

        public bool IsOpen()
        {
            return serial.IsOpen;
        }

        public void Pause(int microsecond)
        {
            sw.Start();
            do
            {
            }
            while(StopWacthUtils.ElapsedMicroSeconds(sw) < microsecond);
            sw.Stop();
        }
    }
}
