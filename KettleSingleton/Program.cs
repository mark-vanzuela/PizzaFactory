using System;

namespace KettleSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Kettle Singleton!");

            Console.WriteLine("Starting...");

            Kettle.Instance.Fill();

            Kettle.Instance.Boil();

            Kettle.Instance.Drain();

            Console.ReadLine();
        }
    }
}
