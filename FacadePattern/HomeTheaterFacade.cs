using System;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amp;
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;
        private Projector _projector;
        private Screen _screen;
        private TheaterLights _lights;
        private PopcornPopper _popcornPopper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvdPlayer,
                                 CdPlayer cdPlayer, Projector projector,
                                 Screen screen, TheaterLights lights,
                                 PopcornPopper popcornPopper)
        {
            _amp = amp;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");

            _popcornPopper.On();
            Console.WriteLine("Popcorn popper on.");
            _popcornPopper.Pop();
            Console.WriteLine("Popcorn is popping!");

            _lights.Dim(10);
            Console.WriteLine("Lights dimmed to 10%.");

            _screen.Down();
            Console.WriteLine("Theater screen going down.");

            _projector.On();
            Console.WriteLine("Projector on.");
            _projector.SetInput(_dvdPlayer);
            Console.WriteLine("Projector input set to DVD player.");
            _projector.WideScreenMode();
            Console.WriteLine("Projector in widescreen mode.");

            _amp.On();
            Console.WriteLine("Amplifier on.");
            _amp.SetDvd(_dvdPlayer);
            Console.WriteLine("Amplifier DVD input set.");
            _amp.SetSurroundSound();
            Console.WriteLine("Amplifier surround sound enabled.");
            _amp.SetVolume(5);
            Console.WriteLine("Amplifier volume set to 5.");

            _dvdPlayer.On();
            Console.WriteLine("DVD player on.");
            _dvdPlayer.Play(movie);
            Console.WriteLine($"Playing movie \"{movie}\"...");
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");

            _popcornPopper.Off();
            Console.WriteLine("Popcorn popper off.");

            _lights.On();
            Console.WriteLine("Lights on.");

            _screen.Up();
            Console.WriteLine("Screen going up.");

            _projector.Off();
            Console.WriteLine("Projector off.");

            _amp.Off();
            Console.WriteLine("Amplifier off.");

            _dvdPlayer.Stop();
            Console.WriteLine("DVD stopped.");
            _dvdPlayer.Eject();
            Console.WriteLine("DVD ejected.");
            _dvdPlayer.Off();
            Console.WriteLine("DVD player off.");
        }
    }
}
