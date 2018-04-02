using DecoratorPattern.Core;

namespace DecoratorPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage) => this.beverage = beverage;

        public override string Description => $"{beverage.Description}, Whip";

        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}