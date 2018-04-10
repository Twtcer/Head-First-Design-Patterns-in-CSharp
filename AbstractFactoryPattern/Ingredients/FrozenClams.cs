using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.Ingredients
{
    public class FrozenClams: IClams
    {
        public string Name { get; } = "Frozen Clams";
    }
}
