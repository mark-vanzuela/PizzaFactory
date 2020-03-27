using System.Collections.Generic;

namespace PizzaFactoryConsole
{
    public class PizzeriaBIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Parmesan();
        }

        public Clam CreateClam()
        {
            return new FreshClam();
        }

        public Dough CreateDough()
        {
            return new DeepDish();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomato();
        }

        public IList<Veggies> CreateVeggies()
        {
            return new List<Veggies> { new Cucumber(), new Onions(), new BellPeppers() };
        }
    }
}