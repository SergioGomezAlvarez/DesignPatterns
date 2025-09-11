using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

internal abstract class Duck

{
    public abstract void Display();
    protected QuackBehavior quackBehavior;

    protected FlyBehavior flyBehavior;

    protected SwimBehavior swimBehavior;



    public void PerformQuack()

    {

        quackBehavior.Quack();

    }

    public void PerformFly()

    {

        flyBehavior.Fly();

    }

    public void PerformSwim()

    {

        swimBehavior.Swim();

    }

    public void SetFlyBehavior(FlyBehavior fb)
    {
        flyBehavior = fb;
    }

    public void SetQuackBehavior(QuackBehavior qb)
    {
        quackBehavior = qb;
    }

    public void SetSwimBehavior(SwimBehavior sb)
    {
        swimBehavior = sb;
    }
}