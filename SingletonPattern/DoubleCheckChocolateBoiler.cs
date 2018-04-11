namespace SingletonPattern
{
    public class DoubleCheckChocolateBoiler
    {
        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }

        private static volatile DoubleCheckChocolateBoiler _uniqueInstance;
        private static readonly object LockHelper = new object();

        private DoubleCheckChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static DoubleCheckChocolateBoiler GetInstance()
        {
            if (_uniqueInstance == null)
            {
                lock (LockHelper)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new DoubleCheckChocolateBoiler();
                    }
                }
            }
            return _uniqueInstance;
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
