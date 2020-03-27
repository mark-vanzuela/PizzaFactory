using System;
using System.Linq;

namespace PizzaFactoryConsole
{
    public class VeggiePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        private readonly IBoxFactory _boxFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory, IBoxFactory boxFactory)
        {
            _ingredientFactory = ingredientFactory;
            _boxFactory = boxFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}...");
            Dough = _ingredientFactory.CreateDough();
            Console.WriteLine($"Creating {Dough}...");
            Sauce = _ingredientFactory.CreateSauce();
            Console.WriteLine($"Adding {Sauce}...");
            Cheese = _ingredientFactory.CreateCheese();
            Console.WriteLine($"Adding {Cheese}...");
            Veggies = _ingredientFactory.CreateVeggies();
            Console.WriteLine($"Adding Veggies... {string.Join(",", Veggies.Select(f => f.ToString()))}");
        }

        public override void Box()
        {
            Console.WriteLine($"Putting pizza in {_boxFactory.CreateBox().GetBoxColor()} coloured box");
        }
    }
}