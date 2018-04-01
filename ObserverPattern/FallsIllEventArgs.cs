using System;

namespace ObserverPattern
{
    public class FallsIllEventArgs : EventArgs
    {
        public readonly string Address;

        public FallsIllEventArgs(string address)
        {
            this.Address = address;
        }
    }
}