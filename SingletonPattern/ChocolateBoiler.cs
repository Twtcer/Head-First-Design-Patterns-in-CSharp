namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }

        private static ChocolateBoiler _uniqueInstance;

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            return _uniqueInstance ?? (_uniqueInstance = new ChocolateBoiler());
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
