using System.Collections;
using IteratorPattern.Abstractions;
using IteratorPattern.MenuIterators;

namespace IteratorPattern.Menus
{
    public class MyPancakeHouseMenu
    {
        public ArrayList MenuItems { get; }

        public MyPancakeHouseMenu()
        {
            MenuItems = new ArrayList();
            AddItem("K&B’s Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem);
        }

        public IMyIterator CreateIterator()
        {
            return new MyPancakeHouseMenuIterator(MenuItems);
        }
    }
}
