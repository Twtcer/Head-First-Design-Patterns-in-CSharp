using System;
using CompositePattern.Abstractions;

namespace CompositePattern.Menus
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override string Name { get; }
        public override string Description { get; }
        public override bool IsVegetarian { get; }
        public override double Price { get; }

        public override void Print()
        {
            Console.Write($"\t{Name}");
            if (IsVegetarian)
            {
                Console.Write("(v)");
            }

            Console.WriteLine($", {Price}");
            Console.WriteLine($"\t -- {Description}");
        }
    }
}
