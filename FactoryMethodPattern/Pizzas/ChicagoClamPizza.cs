namespace FactoryMethodPattern.Pizzas
{
    public class ChicagoClamPizza : Pizza
    {
        public ChicagoClamPizza()
        {
            Name = "Chicago Clam Pizza";
            Sauce = "Tomato sauce 1";
            Dough = "Soft dough 1";
            Toppings.Add("Shrimp meat 1");
        }
    }
}
