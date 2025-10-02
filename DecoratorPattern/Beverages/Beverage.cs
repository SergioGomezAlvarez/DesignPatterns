namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }

    internal abstract class Beverage
    {
        private Size size;
        public Size Size
        {
            get
            {
                if (baseBeverage != null)
                {
                    return baseBeverage.Size;
                }
                return size;
            }
            set { size = value; }
        }

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
