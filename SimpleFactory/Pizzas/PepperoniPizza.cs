namespace SimpleFactory.Pizzas
{
    public class PepperoniPizza: Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Dough = "Thin dough";
            Sauce = "Black pepper";
            Toppings.Add("Beef Granules");
            Toppings.Add("Niblet");
        }
    }
}
