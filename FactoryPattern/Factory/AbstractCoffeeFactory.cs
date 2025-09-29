using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;

namespace DecoratorPattern.Factories
{
    internal abstract class AbstractCoffeeFactory
    {
        public abstract Beverage CreateDrink(DrinkType type, Size size = Size.TALL);
        public virtual Beverage OrderDrink(DrinkType type, Size size = Size.TALL)
        {
            Beverage beverage = CreateDrink(type, size);
            PrepareBeverage(beverage);
            return beverage;
        }

        protected virtual void PrepareBeverage(Beverage beverage)
        {
        }
    }
}
