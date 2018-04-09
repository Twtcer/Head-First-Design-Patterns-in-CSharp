using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ordered a {pizza.Name} in NY");
            Console.WriteLine();
            var pizza2 = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Ordered a {pizza2.Name} in Chicago");

            Console.ReadKey();
        }
    }
}
