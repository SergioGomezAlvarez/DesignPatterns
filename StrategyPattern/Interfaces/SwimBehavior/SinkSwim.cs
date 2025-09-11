using System;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal class SinkSwim : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I’m sinking right now!");
        }
    }
}