using System;
using System.Collections;
using System.Reflection.Emit;

namespace PizzaFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Pizzeria Factory!");

            Pizzeria pizzeriaA = new PizzeriaA();
            Pizzeria pizzeriaB = new PizzeriaB();

            Pizza pizza;

            pizza = pizzeriaA.OrderPizza("Cheese Pizza");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaA.OrderPizza("Clam Pizza");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaA.OrderPizza("Veggie Pizza");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaB.OrderPizza("Cheese Pizza");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaB.OrderPizza("Clam Pizza");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaB.OrderPizza("Veggie Pizza");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");
        }
    }
}
