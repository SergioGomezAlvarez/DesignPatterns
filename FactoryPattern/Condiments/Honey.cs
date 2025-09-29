using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Honey : CondimentDecorator
    {
        public Honey(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return 0.25 + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Honey";
        }
    }
}
