using System;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can’t fly!");
        }
    }
}