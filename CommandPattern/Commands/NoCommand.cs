using CommandPattern.Abstractions;

namespace CommandPattern.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}