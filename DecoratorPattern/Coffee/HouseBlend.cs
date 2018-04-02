using DecoratorPattern.Core;

namespace DecoratorPattern.Coffee
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}