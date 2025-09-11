using System;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal class RegularQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}