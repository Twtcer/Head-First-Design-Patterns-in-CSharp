using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.Ingredients
{
    public class ThickCrustDough: IDough
    {
        public string Name { get; } = "Thick Crust Dough";
    }
}
