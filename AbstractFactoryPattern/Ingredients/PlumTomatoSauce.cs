using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.Ingredients
{
    public class PlumTomatoSauce : ISauce
    {
        public string Name { get; } = "Plum Tomato Sauce";
    }
}
