using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;
using DecoratorPattern.Factory;

internal class Program
{
    static void Main(string[] args)
    {
        AbstractCoffeeFactory italianFactory = new ItalianCoffeeFactory();
        AbstractCoffeeFactory americanFactory = new AmericanCoffeeFactory();

        italianFactory.OrderDrink(DrinkType.Espresso, Size.TALL);
        americanFactory.OrderDrink(DrinkType.Americano, Size.VENDI);
        italianFactory.OrderDrink(DrinkType.Mocha, Size.GRANDE);
        americanFactory.OrderDrink(DrinkType.Latte, Size.GRANDE);
    }
}
