using System.Collections;

namespace IteratorPattern.Abstractions
{
    public interface IMenu
    {
        IEnumerator CreateIEnumerator();
    }
}
