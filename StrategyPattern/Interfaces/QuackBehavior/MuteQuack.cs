using System;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}