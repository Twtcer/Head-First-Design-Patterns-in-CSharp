using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.Ingredients
{
    public class ReggianoCheese : ICheese
    {
        public string Name { get; } = "Reggiano Cheese";
    }
}
