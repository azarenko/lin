using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lin
{
    class TestPort : IPort
    {
        private int index = 0;
        private bool isOpen = false;
        private byte[] testData = new byte[]
        {
            0x00, 0x55, 0x03, 0x00, 0x00, 0xC0, 0x3F,
            0x00, 0x55, 0x03, 0x00, 0x45, 0xC0, 0x3F,
            0x00, 0x55, 0x04, 0x00, 0x00, 0xC0, 0x3F,
            0x00, 0x55, 0x12, 0x00, 0x00, 0xC0, 0x3F,
            0x00, 0x55, 0x11, 0x00, 0x00, 0xC0, 0x3F,
            0x00, 0x55, 0x11, 0x00, 0x00, 0xC0, 0x3F,
            0x00, 0x55, 0x04, 0x22, 0x00, 0xC0, 0x3F
        };

        public void Connect(int speed)
        {
            isOpen = true;
        }

        public void Disconnect()
        {
            isOpen = false;
        }

        public byte Receive()
        {
            if(!isOpen)
                throw new Exception("Test port is not open");

            Thread.Sleep(10);

            if (index >= testData.Length)
            {
                index = 0;
                Thread.Sleep(100);
            } 
            return testData[index++];
        }

        public void Transmmit(byte[] buffer)
        {
            if(!isOpen)
                throw new Exception("Test port is not open");
        }

        public bool IsOpen()
        {
            return isOpen;
        }
    }
}
