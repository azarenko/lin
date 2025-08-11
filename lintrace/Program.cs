using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;

namespace lintrace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baudRate = int.Parse(args[1]);

            using (SerialPort port = new SerialPort(args[0], baudRate, Parity.None, 8, StopBits.One))
            using (StreamWriter sw = new StreamWriter("trace.log"))
            {

            }
        }
    }
}
