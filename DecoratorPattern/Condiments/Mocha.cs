using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.baseBeverage = beverage;
            this.Size = beverage.Size;
        }

        private double GetCondimentPriceBySize(double tallPrice, double grandePrice, double vendiPrice)
        {
            switch (baseBeverage.Size)
            {
                case Size.TALL:
                    return tallPrice;
                case Size.GRANDE:
                    return grandePrice;
                case Size.VENDI:
                    return vendiPrice;
                default:
                    return tallPrice;
            }
        }

        public override double cost()
        {
            return GetCondimentPriceBySize(0.10, 0.15, 0.20) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Mocha";
        }
    }
}
