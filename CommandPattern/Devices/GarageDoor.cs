using System;

namespace CommandPattern.Devices
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("GarageDoor is open.");
        }

        public void Down()
        {
            Console.WriteLine("GarageDoor is closed.");
        }
    }
}