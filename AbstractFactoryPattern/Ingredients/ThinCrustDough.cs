using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.Ingredients
{
    public class ThinCrustDough: IDough
    {
        public string Name { get; } = "Thin Crust Dough";
    }
}
