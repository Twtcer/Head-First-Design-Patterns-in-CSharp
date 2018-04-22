using System.Collections;

namespace IteratorPattern.MenuIterators
{
    public class PancakeHouseMenuIterator : IEnumerator
    {
        private readonly ArrayList _menuItems;
        private int _position = -1;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool MoveNext()
        {
            _position++;
            if (_position >= _menuItems.Count || _menuItems[_position] == null)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current => _menuItems[_position];
    }
}
