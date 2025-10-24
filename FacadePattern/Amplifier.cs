using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier on.");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off.");
        }
        public void SetCd(CdPlayer cdPlayer)
        {
            this._cdPlayer = cdPlayer;
        }
        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("Amplifier DVD input set.");
        }
        public void SetStereoSound()
        {

        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier surround sound enabled.");
        }
        public void SetTuner(Tuner tuner)
        {
            this._tuner = tuner;
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("Amplifier volume set to 5.");
        }

    }
}
