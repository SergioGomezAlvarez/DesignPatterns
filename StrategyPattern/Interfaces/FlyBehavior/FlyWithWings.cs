using System;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I’m flying using my wings!");
        }
    }
}