using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.Ingredients
{
    public class FreshClams : IClams
    {
        public string Name { get; } = "Fresh Clams";
    }
}
