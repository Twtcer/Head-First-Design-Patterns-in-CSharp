namespace CommandPattern.Abstractions
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}