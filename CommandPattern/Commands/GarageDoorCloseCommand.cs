using CommandPattern.Abstractions;
using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
        }

        public void Undo()
        {
            garageDoor.Up();
        }
    }
}