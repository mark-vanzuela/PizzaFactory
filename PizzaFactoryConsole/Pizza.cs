using System;
using System.Collections.Generic;

namespace PizzaFactoryConsole
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected Cheese Cheese { get; set; }
        protected Clam Clam { get; set; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected IList<Veggies> Veggies { get; set; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking at 135 degree Celsius for 25 minutes");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting into diagonal pieces");
        }

        public abstract void Box();

        public string PrintPizza()
        {
            return "PrintPizza";
        }
    }
}