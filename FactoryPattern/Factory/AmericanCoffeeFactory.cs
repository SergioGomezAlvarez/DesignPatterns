using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factory;

namespace DecoratorPattern.Factories
{
    internal class AmericanCoffeeFactory : AbstractCoffeeFactory
    {
        public override Beverage CreateDrink(DrinkType type, Size size = Size.TALL)
        {
            switch (type)
            {
                case DrinkType.Americano:
                    Beverage americano = new Espresso(size);
                    americano = new Water(size, americano);
                    americano = new Water(size, americano);
                    return americano;
                case DrinkType.FlatWhite:
                    Beverage flatWhite = new Espresso(size);
                    flatWhite = new SteamedMilk(flatWhite);
                    flatWhite = new SteamedMilk(flatWhite);
                    return flatWhite;
                case DrinkType.Latte:
                    Beverage latte = new Espresso(size);
                    latte = new SteamedMilk(latte);
                    latte = new SteamedMilk(latte);
                    latte = new MilkFoam(latte);
                    return latte;
                default:
                    throw new ArgumentException("Onbekend drankje type voor Amerikaanse store");
            }
        }
    }
}
