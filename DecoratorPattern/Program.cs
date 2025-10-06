using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var beverages = new List<Beverage>();

            var espressoGrande = new Espresso(Size.GRANDE);
            var espressoTall = new Espresso(Size.TALL);
            var espressoVendi = new Espresso(Size.VENDI);
            var chocolateGrande = new Chocolate(Size.GRANDE);

            // Espresso-varianten
            beverages.Add(espressoGrande); // Espresso
            beverages.Add(espressoTall); // Doppio
            beverages.Add(new Water(espressoTall)); // Lungo
            beverages.Add(new MilkFoam(espressoGrande)); // Macchiato
            beverages.Add(new Liquor(espressoGrande)); // Coretta
            beverages.Add(new Whip(espressoGrande)); // Con Panna
            beverages.Add(new MilkFoam(new SteamedMilk(espressoGrande))); // Cappuccino
            beverages.Add(new Water(new Water(espressoVendi))); // Americano
            beverages.Add(new MilkFoam(new SteamedMilk(new SteamedMilk(espressoGrande)))); // Caffé Latte
            beverages.Add(new SteamedMilk(new SteamedMilk(espressoGrande))); // Flat White
            beverages.Add(new Lemon(espressoGrande)); // Romana
            beverages.Add(new Whip(new WhiteChocolate(new BlackChocolate(espressoGrande)))); // Bicerin
            beverages.Add(new HalfMilk(new MilkFoam(espressoGrande))); // Breve
            beverages.Add(new Cream(new VanillaSugar(espressoGrande))); // Raf coffee
            beverages.Add(new Cream(new Honey(espressoGrande))); // Mead raf
            beverages.Add(new MilkFoam(new MilkFoam(espressoGrande))); // Galao
            beverages.Add(new IceCream(espressoGrande)); // Caffé affogato
            beverages.Add(new Whip(new Whip(espressoGrande))); // Vienna coffee
            beverages.Add(new IceCream(espressoGrande)); // Glace
            beverages.Add(new Milk(new Milk(chocolateGrande))); // Chocolate milk
            beverages.Add(new Cream(new Cream(espressoGrande))); // Demi-créme
            beverages.Add(new MilkFoam(new SteamedMilk(new SteamedMilk(espressoGrande)))); // Latte macchiato
            beverages.Add(new Ice(new Liquor(espressoGrande))); // Freddo
            beverages.Add(new Syrup(new Cream(new Whip(new SteamedMilk(new Ice(espressoGrande)))))); // Frappuccino
            beverages.Add(new Syrup(new Cream(new Whip(new SteamedMilk(new Ice(espressoGrande)))))); // Caramel frappuccino
            beverages.Add(new Syrup(new Cream(new Whip(new SteamedMilk(espressoGrande))))); // Frappe
            beverages.Add(new Whiskey(new IceCream(espressoGrande))); // Irish Coffee

            foreach (var beverage in beverages)
                PrintBeverage(beverage);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine("Beschrijving: " + beverage.GetDescription());
            Console.WriteLine("Maat: " + beverage.Size);
            Console.WriteLine("Prijs: $" + beverage.cost().ToString("#.##"));
            Console.WriteLine();
        }
    }
}
