using System;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}