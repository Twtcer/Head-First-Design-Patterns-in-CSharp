using System;
using TemplateMethodPattern.Beverages;
using TemplateMethodPattern.ForArraySort;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortDuck();

            Console.ReadKey();
        }

        static void SortDuck()
        {
            var ducks = new Duck[]
            {
                new Duck("Duffy", 8),
                new Duck("Dewey",  2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donal", 10),
                new Duck("Huey", 3)
            };
            Console.WriteLine("Before sorting:");
            DisplayDucks(ducks);

            Array.Sort(ducks);

            Console.WriteLine();
            Console.WriteLine("After sorting:");
            DisplayDucks(ducks);
        }

        private static void DisplayDucks(Duck[] ducks)
        {
            foreach (Duck t in ducks)
            {
                Console.WriteLine(t);
            }
        }

        static void MakeTea()
        {
            var tea = new Tea();
            tea.PrepareRecipe();
        }

        static void MakeCoffeeWithHook()
        {
            var coffeeWithHook = new CoffeeWithHook();
            Console.WriteLine("Making coffee...");
            coffeeWithHook.PrepareRecipe();
        }
    }
}
