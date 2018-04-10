using System;
using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.ConcreteProducts
{
    public class CheesePizza: Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing: {Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Clams = _pizzaIngredientFactory.CreateClams();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Console.WriteLine($"    {Dough.Name}");
            Console.WriteLine($"    {Sauce.Name}");
            Console.WriteLine($"    {Clams.Name}");
            Console.WriteLine($"    {Cheese.Name}");
        }
    }
}
