namespace Lin
{
    interface IPort
    {
        byte Receive();
        void Transmmit(byte[] buffer);
        void Connect(int speed);
        void Disconnect();
        bool IsOpen();
    }
}
