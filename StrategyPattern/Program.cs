using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
           

            Duck redhead = new RedheadDuck();
            redhead.PerformFly();
            redhead.PerformQuack();

            Duck decoy = new DecoyDuck();
            decoy.PerformFly();
            decoy.PerformQuack();

            Duck rubber = new RubberDuck();
            rubber.PerformFly();
            rubber.PerformQuack();

            Duck robot = new RobotDuck();
            robot.PerformFly();
            robot.PerformQuack();
            robot.PerformSwim();
            robot.SetSwimBehavior(new FloatSwim());
            robot.PerformSwim();
        }
    }
}