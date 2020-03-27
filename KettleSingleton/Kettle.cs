using System;
using System.Collections.Generic;
using System.Text;

namespace KettleSingleton
{
    public sealed class Kettle
    {
        Kettle()
        {
        }
        private static readonly object padlock = new object();
        private static Kettle instance = null;
        public static Kettle Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Kettle();
                    }
                    return instance;
                }
            }
        }

        public State State { get; set; } = State.Empty;

        public void Fill()
        {
            if (State == State.Empty)
            {
                Console.WriteLine("Filling...");
                State = State.Boiling;
            }
        }

        public void Drain()
        {
            if (State != State.Boiling)
                Console.WriteLine("Draining...");
            State = State.Empty;
        }

        public void Boil()
        {
            if (State == State.Boiling)
                Console.WriteLine("Boiling...");
            State = State.Boiled;
        }
    }

    public enum State
    {
        Empty,
        InProgress,
        Boiled,
        Boiling
    }
}
