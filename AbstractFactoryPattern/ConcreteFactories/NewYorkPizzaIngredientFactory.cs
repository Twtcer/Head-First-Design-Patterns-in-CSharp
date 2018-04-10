using AbstractFactoryPattern.Abstractions;
using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern.ConcreteFactories
{
    public class NewYorkPizzaIngredientFactory: IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
