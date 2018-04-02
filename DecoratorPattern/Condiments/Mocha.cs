using DecoratorPattern.Core;

namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Mocha(Beverage beverage) => this.beverage = beverage;

        public override string Description => $"{beverage.Description}, Mocha";

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}