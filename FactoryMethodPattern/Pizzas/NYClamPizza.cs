namespace FactoryMethodPattern.Pizzas
{
    public class NYClamPizza: Pizza
    {
        public NYClamPizza()
        {
            Name = "NY  Clam Pizza";
            Sauce = "Tomato sauce 2";
            Dough = "Soft dough 2";
            Toppings.Add("Shrimp meat 2");
        }
    }
}
