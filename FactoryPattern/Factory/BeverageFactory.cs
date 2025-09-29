using System;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory
{

    internal static class BeverageFactory
    {
        public static Beverage CreateDrink(DrinkType type, Size size = Size.TALL)
        {
            Beverage beverage;

            switch (type)
            {
                case DrinkType.Espresso:
                    beverage = new Espresso(size);
                    break;

                case DrinkType.Americano:
                    beverage = new Espresso(size);
                    beverage = new Water(size, beverage);
                    beverage = new Water(size, beverage);
                    break;

                case DrinkType.Cappuccino:
                    beverage = new Espresso(size);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case DrinkType.Mocha:
                    beverage = new Espresso(size);
                    beverage = new Mocha(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.Latte:
                    beverage = new Espresso(size);
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case DrinkType.FlatWhite:
                    beverage = new Espresso(size);
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;

                case DrinkType.Bicerin:
                    beverage = new Espresso(size);
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    break;

                default:
                    throw new ArgumentException("Onbekend drankje type");
            }

            return beverage;
        }
    }
}
