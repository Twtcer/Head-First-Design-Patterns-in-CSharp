using AdapterPattern.Abstractions;

namespace AdapterPattern.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}