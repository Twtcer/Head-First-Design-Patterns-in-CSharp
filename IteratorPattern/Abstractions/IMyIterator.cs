namespace IteratorPattern.Abstractions
{
    public interface IMyIterator
    {
        bool HasNext();
        object Next();
    }
}
