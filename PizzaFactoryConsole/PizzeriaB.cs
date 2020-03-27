namespace PizzaFactoryConsole
{
    public class PizzeriaB : Pizzeria
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new PizzeriaBIngredientFactory();
            IBoxFactory boxFactory = new PizzeriaBBoxFactory();

            if (pizzaType.Equals("Cheese Pizza"))
            {
                pizza = new CheesePizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria B {pizzaType}"
                };
            }
            else if (pizzaType.Equals("Clam Pizza"))
            {
                pizza = new ClamPizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria B {pizzaType}"
                };
            }
            else if (pizzaType.Equals("Veggie Pizza"))
            {
                pizza = new VeggiePizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria B {pizzaType}"
                };
            }


            return pizza;
        }
    }
}