using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Equipments
{
    public class TheaterLights
    {
        private int _brightness;

        public void Dim(int brightness)
        {
            _brightness = brightness;
            Console.WriteLine($"Theater lights dimming on {_brightness}");
        }

        public void On()
        {
            _brightness = 10;
            Console.WriteLine("Theater lights on");
        }
    }
}
