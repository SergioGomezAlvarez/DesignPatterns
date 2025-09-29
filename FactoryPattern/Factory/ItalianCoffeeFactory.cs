using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factory;

namespace DecoratorPattern.Factories
{
    internal class ItalianCoffeeFactory : AbstractCoffeeFactory
    {
        public override Beverage CreateDrink(DrinkType type, Size size = Size.TALL)
        {
            switch (type)
            {
                case DrinkType.Espresso:
                    return new Espresso(size);
                case DrinkType.Cappuccino:
                    Beverage cappuccino = new Espresso(size);
                    cappuccino = new SteamedMilk(cappuccino);
                    cappuccino = new MilkFoam(cappuccino);
                    return cappuccino;
                case DrinkType.Mocha:
                    Beverage mocha = new Espresso(size);
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
