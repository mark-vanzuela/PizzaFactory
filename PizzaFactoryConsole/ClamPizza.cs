using System;

namespace PizzaFactoryConsole
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        private readonly IBoxFactory _boxFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory, IBoxFactory boxFactory)
        {
            _ingredientFactory = ingredientFactory;
            _boxFactory = boxFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}...");
            Dough = _ingredientFactory.CreateDough();
            Console.WriteLine($"Creating {Dough}...");
            Clam = _ingredientFactory.CreateClam();
            Console.WriteLine($"Adding {Clam}...");
            Sauce = _ingredientFactory.CreateSauce();
            Console.WriteLine($"Adding {Sauce}...");
            Cheese = _ingredientFactory.CreateCheese();
            Console.WriteLine($"Adding {Cheese}...");
        }

        public override void Box()
        {
            Console.WriteLine($"Putting pizza in {_boxFactory.CreateBox().GetBoxColor()} coloured box");
        }
    }
}