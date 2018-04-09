namespace FactoryMethodPattern.Pizzas
{
    public class NYPepperoniPizza: Pizza
    {
        public NYPepperoniPizza()
        {
            Name = "NY Pepperoni Pizza";
            Dough = "Thin dough 2";
            Sauce = "Black pepper 2";
            Toppings.Add("Beef Granules 2");
            Toppings.Add("Niblet 2");
        }
    }
}
