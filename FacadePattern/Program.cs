namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            CdPlayer cdPlayer = new CdPlayer(amp);
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            PopcornPopper popcornPopper = new PopcornPopper();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amp, tuner, dvdPlayer, cdPlayer, projector, screen, lights, popcornPopper);

            homeTheater.WatchMovie("Die Hard");

            Console.WriteLine();
            Console.WriteLine("Press any key to end the movie...");
            Console.ReadKey();

            homeTheater.EndMovie();
        }
    }
}
