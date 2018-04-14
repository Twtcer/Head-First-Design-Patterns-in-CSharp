using System;

namespace CommandPattern.Devices
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }
}