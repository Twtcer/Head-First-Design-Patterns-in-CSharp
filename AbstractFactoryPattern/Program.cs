using System;
using AbstractFactoryPattern.Clients;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var newYorkPizzaStore = new NewYorkPizzaStore();
            newYorkPizzaStore.OrderPizza("cheese");

            Console.WriteLine("-----------------------------------------------------------");

            var chicagoYorkPizzaStore = new ChicagoPizzaStore();
            chicagoYorkPizzaStore.OrderPizza("cheese");

            Console.ReadKey();
        }
    }
}
