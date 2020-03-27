using System;
using System.Linq;

namespace PizzaFactoryConsole
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        private readonly IBoxFactory _boxFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory, IBoxFactory boxFactory)
        {
            _ingredientFactory = ingredientFactory;
            _boxFactory = boxFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}...");
            Dough = _ingredientFactory.CreateDough();
            Console.WriteLine($"Creating {Dough}...");
            Cheese = _ingredientFactory.CreateCheese();
            Console.WriteLine($"Adding {Cheese}...");
            Sauce = _ingredientFactory.CreateSauce();
            Console.WriteLine($"Adding {Sauce}...");
            Veggies = _ingredientFactory.CreateVeggies();
            Console.WriteLine($"Adding Veggies... {string.Join(",",Veggies.Select(f => f.ToString()))}");
        }

        public override void Box()
        {
            Console.WriteLine($"Putting pizza in {_boxFactory.CreateBox().GetBoxColor()} coloured box");
        }
    }
}