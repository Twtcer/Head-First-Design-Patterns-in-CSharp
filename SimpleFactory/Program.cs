using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new PizzaStore(new SimplePizzaFactory());
            var cheesePizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine();
            var clamPizza = pizzaStore.OrderPizza("pepperoni");
            Console.ReadKey();
        }
    }
}
