using System.Collections.Generic;

namespace PizzaFactoryConsole
{
    public interface IPizzaIngredientFactory
    {
        Cheese CreateCheese();
        Clam CreateClam();
        Dough CreateDough();
        Sauce CreateSauce();
        IList<Veggies> CreateVeggies();
    }
}