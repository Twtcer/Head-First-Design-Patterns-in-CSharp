using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.Ingredients
{
    public class MarinaraSauce: ISauce
    {
        public string Name { get; } = "Marinara Sauce";
    }
}
