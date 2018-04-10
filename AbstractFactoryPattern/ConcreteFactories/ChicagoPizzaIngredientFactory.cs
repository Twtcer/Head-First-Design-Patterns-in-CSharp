using AbstractFactoryPattern.Abstractions;
using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern.ConcreteFactories
{
    public class ChicagoPizzaIngredientFactory: IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
