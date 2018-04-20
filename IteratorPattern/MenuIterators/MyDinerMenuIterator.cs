using IteratorPattern.Abstractions;
using IteratorPattern.Menus;

namespace IteratorPattern.MenuIterators
{
    public class MyDinerMenuIterator: IMyIterator
    {
        private readonly MenuItem[] _items;
        private int _position;

        public MyDinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            var menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}
