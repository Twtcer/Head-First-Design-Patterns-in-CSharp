using System;
using System.Collections;
using IteratorPattern.Menus;
using IteratorPattern.Waitresses;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuTestDriveUsingIEnumerator();
            Console.ReadKey();
        }

        static void MenuTestDriveUsingMyIterator()
        {
            var pancakeHouseMenu = new MyPancakeHouseMenu();
            var dinerMenu = new MyDinerMenu();

            var waitress = new MyWaitress(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }

        static void MenuTestDriveUsingIEnumerator()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var cafeMenu = new CafeMenu();

            var waitress = new Waitress(new ArrayList(3)
            {
                pancakeHouseMenu, dinerMenu, cafeMenu
            });
            waitress.PrintMenu();
        }
    }
}
