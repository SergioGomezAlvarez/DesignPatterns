using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factory;

namespace DecoratorPattern.Factories
{
    internal class AmericanCoffeeFactory : AbstractCoffeeFactory
    {
        protected override Beverage CreateDrink(DrinkType type)
        {
            switch (type)
            {
                case DrinkType.Americano:
                    Beverage americano = new Espresso();
                    americano = new Water(americano.Size, americano);
                    americano = new Water(americano.Size, americano);
                    return americano;
                case DrinkType.FlatWhite:
                    Beverage flatWhite = new Espresso();
                    flatWhite = new SteamedMilk(flatWhite);
                    flatWhite = new SteamedMilk(flatWhite);
                    return flatWhite;
                case DrinkType.Latte:
                    Beverage latte = new Espresso();
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
