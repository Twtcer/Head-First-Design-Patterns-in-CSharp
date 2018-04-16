using System;
using FacadePattern.Equipments;
using FacadePattern.Facades;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new HomeTheaterFacade(new Amplifier(), new DvdPlayer(), new Projector(), new TheaterLights(), new Screen(), new PopcornPopper());
            facade.WatchMovie("Ready Player One");
            facade.EndMovie();

            Console.ReadKey();
        }
    }
}
