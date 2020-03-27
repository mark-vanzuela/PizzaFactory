namespace PizzaFactoryConsole
{
    public abstract class Pizzeria
    {
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }

        protected abstract Pizza CreatePizza(string pizzaType);
    }
}