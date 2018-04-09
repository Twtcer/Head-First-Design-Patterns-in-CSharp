using System;
using System.Collections.Generic;

namespace SimpleFactory
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void Prepare()
        {

            Console.WriteLine($"准备: {name}");
            Console.WriteLine($"扔: {dough}");
            Console.WriteLine($"添加: {sauce}");
            Console.WriteLine("添加点缀: ");
            toppings.ForEach(x => Console.WriteLine($"  {x}"));
        }

        public void bake()
    }
}