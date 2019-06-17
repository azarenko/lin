using System;
using System.Collections.Generic;
using System.Text;

namespace Lin
{
    class PortFactory
    {
        public static IPort GetPort(string Name)
        {
            if (StaticContainer.isTest)
            {
                return new TestPort();
            }
            else
            {
                return new RealPort(Name);
            }
        }
    }
}
