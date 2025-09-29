using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;
using DecoratorPattern.Factory;

internal class Program
{
    static void Main(string[] args)
    {
        AbstractCoffeeFactory italianFactory = new ItalianCoffeeFactory();
        AbstractCoffeeFactory americanFactory = new AmericanCoffeeFactory();

        Beverage espresso = italianFactory.OrderDrink(DrinkType.Espresso, Size.TALL);
        PrintBeverage(espresso);

        Beverage americano = americanFactory.OrderDrink(DrinkType.Americano, Size.VENDI);
        PrintBeverage(americano);

        Beverage mocha = italianFactory.OrderDrink(DrinkType.Mocha, Size.GRANDE);
        PrintBeverage(mocha);

        Beverage latte = americanFactory.OrderDrink(DrinkType.Latte, Size.GRANDE);
        PrintBeverage(latte);
    }

    static void PrintBeverage(Beverage beverage)
    {
        Console.WriteLine("Beschrijving: " + beverage.GetDescription());
        Console.WriteLine("Maat: " + beverage.Size);
        Console.WriteLine("Prijs: $" + beverage.cost().ToString("#.##"));
        Console.WriteLine();
    }
}
