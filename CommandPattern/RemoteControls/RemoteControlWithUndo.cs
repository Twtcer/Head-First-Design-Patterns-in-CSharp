using System.Text;
using CommandPattern.Abstractions;
using CommandPattern.Commands;

namespace CommandPattern.RemoteControls
{
    public class RemoteControlWithUndo
    {
        private ICommand[] onCommands;
        private ICommand[] offCommands;
        private ICommand undoCommand;

        public RemoteControlWithUndo()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            var noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {            
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder("\n------------Remote Control With Undo-----------\n");
            for(int i =0; i< onCommands.Length; i++){
                sb.Append($"[slot{i}] {onCommands[i].GetType()}\t{offCommands[i].GetType()} \n");
            }
            return sb.ToString();
        }
    }
}