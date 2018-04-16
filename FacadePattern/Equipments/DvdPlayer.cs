using System;

namespace FacadePattern.Equipments
{
    public class DvdPlayer
    {
        private string _movie;

        public void On()
        {
            Console.WriteLine("DVD player on");
        }

        public void Play(string movie)
        {
            _movie = movie;
            Console.WriteLine($"DVD player playing {_movie}");
        }

        public void Stop()
        {
            Console.WriteLine($"DVD player stopped \"{_movie}\"");
        }

        public void Eject()
        {
            Console.WriteLine("DVD player eject");
        }

        public void Off()
        {
            Console.WriteLine("DVD player off");
        }
    }
}
