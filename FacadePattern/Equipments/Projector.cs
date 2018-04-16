using System;

namespace FacadePattern.Equipments
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Project in widescreen mode");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }
    }
}
