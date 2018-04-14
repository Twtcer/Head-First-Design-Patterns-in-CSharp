using CommandPattern.Abstractions;
using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Up();
        }

        public void Undo()
        {
            garageDoor.Down();
        }
    }
}