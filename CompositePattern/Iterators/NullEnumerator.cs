using System.Collections;
using System.Collections.Generic;
using CompositePattern.Abstractions;

namespace CompositePattern.Iterators
{
    public class NullEnumerator : IEnumerator<MenuComponent>
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            
        }

        public MenuComponent Current => null;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}