using System;
using FacadePattern.Equipments;

namespace FacadePattern.Facades
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amp;
        private readonly DvdPlayer _dvd;
        private readonly Projector _projector;
        private readonly TheaterLights _lights;
        private readonly Screen _screen;
        private readonly PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amp, DvdPlayer dvd, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            _amp = amp;
            _dvd = dvd;
            _projector = projector;
            _lights = lights;
            _screen = screen;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");

            _popper.On();
            _popper.Pop();
            _lights.Dim(5);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd();
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }
    }
}
