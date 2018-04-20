using System;
using System.Collections;
using IteratorPattern.Abstractions;
using IteratorPattern.Menus;

namespace IteratorPattern.Waitresses
{
    public class Waitress
    {
        private readonly ArrayList _menus;

        public Waitress(ArrayList menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            var menuIterator = _menus.GetEnumerator();
            while (menuIterator.MoveNext())
            {
                var menu = menuIterator.Current as IMenu;
                PrintMenu(menu?.CreateIEnumerator());
            }
        }

        private void PrintMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                if (iterator.Current != null)
                {
                    MenuItem menuItem;
                    if (iterator.Current is MenuItem item)
                    {
                        menuItem = item;
                    }
                    else
                    {
                        menuItem = ((DictionaryEntry)iterator.Current).Value as MenuItem;
                    }
                    Console.Write($"{menuItem?.Name}, ");
                    Console.Write($"{menuItem?.Price} -- ");
                    Console.WriteLine($"{menuItem?.Description}");
                }
            }
            Console.WriteLine();
        }
    }
}
