using AbstractFactoryPattern.Abstractions;
using AbstractFactoryPattern.ConcreteFactories;
using AbstractFactoryPattern.ConcreteProducts;

namespace AbstractFactoryPattern.Clients
{
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var factory = new NewYorkPizzaIngredientFactory();
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "New York Cheese Pizza";
                    break;
                case "clams":
                    pizza = new ClamsPizza(factory);
                    pizza.Name = "New York Clams Pizza";
                    break;
            }
            return pizza;
        }
    }
}
