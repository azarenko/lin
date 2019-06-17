using System.IO;
using System.IO.Ports;

namespace Lin
{
    class RealPort : IPort
    {
        private static SerialPort serial = new SerialPort();
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
            
        }

        public bool IsOpen()
        {
            return serial.IsOpen;
        }
    }
}
