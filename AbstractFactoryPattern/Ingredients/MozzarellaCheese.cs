using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.Ingredients
{
    public class MozzarellaCheese: ICheese
    {
        public string Name { get; } = "Mozzarella Cheese";
    }
}
