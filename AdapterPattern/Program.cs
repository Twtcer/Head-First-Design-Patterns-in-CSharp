using System;
using AdapterPattern.Abstractions;
using AdapterPattern.Adapters;
using AdapterPattern.Turkies;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckTestDrive();
        }

        static void DuckTestDrive()
        {
            IDuck duck = new MallardDuck();
            var turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            System.Console.WriteLine("Turkey says.........");
            turkey.Gobble();
            turkey.Fly();

            System.Console.WriteLine("Duck says.........");
            TestDuck(duck);

            System.Console.WriteLine("TurkeyAdapter says.........");
            TestDuck(turkeyAdapter);
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
