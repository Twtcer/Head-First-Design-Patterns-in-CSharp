using System;
using System.Collections.Generic;

namespace SimpleFactory.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing: {Name}");
            Console.WriteLine($"Tossing: {Dough}");
            Console.WriteLine($"Adding sauce: {Sauce}");
            Console.WriteLine("Adding toppings: ");
            Toppings.ForEach(x => Console.WriteLine($"  {x}"));
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagnol slices");
        }

        public void Box()
        {
            Console.WriteLine("Placing pizza in official PizzaStore box......");
        }
    }
}