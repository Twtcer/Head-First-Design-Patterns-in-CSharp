using System;

namespace FacadePattern.Equipments
{
    public class Screen
    {
        public void Down()
        {
            Console.WriteLine("Screen going down");
        }

        public void Up()
        {
            Console.WriteLine("Screen going up");
        }
    }
}
