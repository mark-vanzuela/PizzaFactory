namespace PizzaFactoryConsole
{
    public class PizzeriaA : Pizzeria
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new PizzeriaAIngredientFactory();
            IBoxFactory boxFactory = new PizzeriaABoxFactory();

            if (pizzaType.Equals("Cheese Pizza"))
            {
                pizza = new CheesePizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria A {pizzaType}"
                };
            }
            else if (pizzaType.Equals("Clam Pizza"))
            {
                pizza = new ClamPizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria A {pizzaType}"
                };
            }
            else if (pizzaType.Equals("Veggie Pizza"))
            {
                pizza = new VeggiePizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria A {pizzaType}"
                };
            }
            

            return pizza;
        }
    }
}