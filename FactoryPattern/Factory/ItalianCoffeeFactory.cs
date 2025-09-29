using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factory;

namespace DecoratorPattern.Factories
{
    internal class ItalianCoffeeFactory : AbstractCoffeeFactory
    {
        protected override Beverage CreateDrink(DrinkType type)
        {
            switch (type)
            {
                case DrinkType.Espresso:
                    return new Espresso();
                case DrinkType.Cappuccino:
                    Beverage cappuccino = new Espresso();
                    cappuccino = new SteamedMilk(cappuccino);
                    cappuccino = new MilkFoam(cappuccino);
                    return cappuccino;
                case DrinkType.Mocha:
                    Beverage mocha = new Espresso();
                    mocha = new Mocha(mocha);
                    mocha = new SteamedMilk(mocha);
                    mocha = new Whip(mocha);
                    return mocha;
                default:
                    throw new ArgumentException("Onbekend drankje type voor Italiaanse store");
            }
        }
    }
}
