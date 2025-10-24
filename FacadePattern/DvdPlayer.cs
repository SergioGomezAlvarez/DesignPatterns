using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD player on.");
        }
        public void Off()
        {
            Console.WriteLine("DVD player off.");

        }
        public void Eject()
        {
            Console.WriteLine("DVD ejected.");
        }
        public void Pause()
        {

        }
        public void Play(string movie)
        {
            Console.WriteLine($"Playing movie \"{movie}\"...");
        }
        public void SetSurroundAudio()
        {

        }
        public void SetTWoChannelAudio()
        {

        }
        public void Stop()
        {
            Console.WriteLine("DVD stopped.");
        }
    }
}
