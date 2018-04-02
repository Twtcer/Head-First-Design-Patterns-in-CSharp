using DecoratorPattern.Core;

namespace DecoratorPattern.Coffee
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}