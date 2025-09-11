using System;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal class FloatSwim : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I’m floating right now!");
        }
    }
}