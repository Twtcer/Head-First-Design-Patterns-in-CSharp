using System;
using CompositePattern.Abstractions;

namespace CompositePattern.Waitresses
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            var enumerator = _allMenus.CreateEnumerator();
            Console.WriteLine("\nVEGETARIAN MENU\n--------");
            while (enumerator.MoveNext())
            {
                var menuComponent = enumerator.Current;
                try
                {
                    if (menuComponent.IsVegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotSupportedException e)
                {
                }
            }
        }
    }
}
