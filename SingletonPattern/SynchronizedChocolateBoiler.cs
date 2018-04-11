using System.Runtime.CompilerServices;

namespace SingletonPattern
{
    public class SynchronizedChocolateBoiler
    {
        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }

        private static SynchronizedChocolateBoiler _uniqueInstance;

        private SynchronizedChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static SynchronizedChocolateBoiler GetInstance()
        {
            return _uniqueInstance ?? (_uniqueInstance = new SynchronizedChocolateBoiler());
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
            }
        }
    }
}
