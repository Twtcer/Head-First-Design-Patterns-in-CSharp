using System;

namespace AbstractFactoryPattern.Abstractions
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; protected set; }
        public ISauce Sauce { get; protected set; }
        public ICheese Cheese { get; protected set; }
        public IClams Clams { get; protected set; }

        public abstract void Prepare();

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
