using AbstractFactoryPattern.Abstractions;
using AbstractFactoryPattern.ConcreteFactories;
using AbstractFactoryPattern.ConcreteProducts;

namespace AbstractFactoryPattern.Clients
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var factory = new ChicagoPizzaIngredientFactory();
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "Chicago Cheese Pizza";
                    break;
                case "clams":
                    pizza = new ClamsPizza(factory);
                    pizza.Name = "Chicago Clams Pizza";
                    break;
            }
            return pizza;
        }
    }
}
