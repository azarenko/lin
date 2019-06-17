using System;
using System.Collections.Generic;
using System.Text;

namespace Lin
{
    static class StaticContainer
    {
        public static bool isTest = false;
        public static List<PacketMonitorItem> databuffer = new List<PacketMonitorItem>();
        public static IPort port;
        public static bool groupByFunc = false;
        public static List<byte> filter = new List<byte>();
    }
}
