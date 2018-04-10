namespace AbstractFactoryPattern.Abstractions
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ICheese CreateCheese();
        IClams CreateClams();
        ISauce CreateSauce();
    }
}
