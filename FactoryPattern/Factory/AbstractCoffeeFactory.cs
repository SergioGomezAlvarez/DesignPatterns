using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;

namespace DecoratorPattern.Factories
{
    internal abstract class AbstractCoffeeFactory
    {
        public Beverage OrderDrink(DrinkType type, Size size = Size.TALL)
        {
            Beverage beverage = CreateDrink(type);
            beverage.Size = size;
            PrepareBeverage(beverage);
            PrintBeverage(beverage);
            return beverage;
        }

        protected abstract Beverage CreateDrink(DrinkType type);

        protected virtual void PrepareBeverage(Beverage beverage)
        {}

        protected virtual void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine("Beschrijving: " + beverage.GetDescription());
            Console.WriteLine("Maat: " + beverage.Size);
            Console.WriteLine("Prijs: $" + beverage.cost().ToString("#.##"));
            Console.WriteLine();
        }
    }
}
