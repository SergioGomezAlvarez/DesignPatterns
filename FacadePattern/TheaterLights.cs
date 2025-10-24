using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Lights on.");
        }

        public void Off()
        {

        }

        public void Dim(int value)
        {
            Console.WriteLine("Lights dimmed to 10%.");
        }
    }
}
