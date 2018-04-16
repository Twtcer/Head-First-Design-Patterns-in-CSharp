using AdapterPattern.Abstractions;

namespace AdapterPattern
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying");
        }

        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}