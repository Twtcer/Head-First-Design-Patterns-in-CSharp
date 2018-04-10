using System;
using AbstractFactoryPattern.Abstractions;

namespace AbstractFactoryPattern.ConcreteProducts
{
    public class ClamsPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public ClamsPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing: {Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Clams = _pizzaIngredientFactory.CreateClams();
            Console.WriteLine($"    {Dough.Name}");
            Console.WriteLine($"    {Sauce.Name}");
            Console.WriteLine($"    {Clams.Name}");
        }
    }
}
