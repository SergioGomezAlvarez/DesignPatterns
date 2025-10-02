using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate(Size size = Size.TALL, Beverage beverage = null)
        {
            this.Size = size;
            description = "Chocolate";
            this.baseBeverage = beverage;
        }

        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }

        public override double cost()
        {
            if (baseBeverage != null)
            {
                return 1.50 + baseBeverage.cost();
            }
            return 1.50;
        }
    }
}
