using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Liquor : CondimentDecorator
    {
        public Liquor(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return 0.50 + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Liquor";
        }
    }
}
