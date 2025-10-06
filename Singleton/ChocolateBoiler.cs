using System;

namespace Singleton
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler instance;

        private static readonly object lockObject = new object();

        public static ChocolateBoiler Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ChocolateBoiler();
                    }
                    return instance;
                }
            }
        }

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public void Fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Boiler filled with chocolate and milk mixture.");
            }
        }

        public void Boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("Boiler contents boiled.");
            }
        }

        public void Drain()
        {
            if (!empty && boiled)
            {
                empty = true;
                Console.WriteLine("Boiler drained.");
            }
        }
    }
}
