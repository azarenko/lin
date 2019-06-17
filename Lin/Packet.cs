using System;
using System.Collections.Generic;

namespace Lin
{
    class Packet
    {
        private const string HexFormat = "X2";

        public DateTime _datetime;
        public Packet()
        {
            _datetime = DateTime.Now;
        }

        public byte Function { get; set; }
        public byte[] Data { get; set; }
        public byte Crc { get; set; }
        public DateTime Time { get { return _datetime; } }

        public bool CompareByAll(Packet other)
        {
            return Function == other.Function
                && CompareByteArray(Data, other.Data);
        }

        public bool CompareByFunction(Packet other)
        {
            return Function == other.Function;
        }

        public string ToStringWithDate()
        {
            return string.Format("T:{0} F:[0x{1}] D:{2}CRC:[0x{3}]", Time.ToString("dd.MM.yyyy hh:mm:ss.ffff"), Function.ToString(HexFormat), ConvertByteArrayToString(Data), Crc.ToString(HexFormat));
        }

        private string ConvertByteArrayToString(byte[] buffer)
        {
            string result = string.Empty;

            foreach (byte b in buffer)
            {
                result += string.Format("[0x{0}={1}] ", b.ToString(HexFormat), Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            return result;
        }

        public string ToStringWithoutDate()
        {
            return string.Format("F:[0x{0}] D:{1}CRC:[0x{2}]", Function.ToString(HexFormat), ConvertByteArrayToString(Data), Crc.ToString(HexFormat));
        }

        private bool CompareByteArray(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        private static byte[] buffer = new byte[128];
        private static int pointer = 0;
        public static bool Parse(byte b, out Packet p)
        {
            p = null;

            pointer = (pointer >= 128 ? 0 : pointer);
            buffer[pointer++] = b;

            if (pointer < 5)
                return false;

            if (buffer[0] == 0x00 && buffer[1] == 0x55 && buffer[pointer-2] == 0x00 && buffer[pointer-1] == 0x55)
            {
                p = new Packet();
                p.Function = buffer[2];
                p.Crc = buffer[pointer - 3];
                p.Data = new byte[pointer - 6];
                for(int i=0; i < p.Data.Length; i++)
                {
                    p.Data[i] = buffer[i + 3];
                }
                pointer = 2;
                return true;
            }

            return false;
        }
    }
}
