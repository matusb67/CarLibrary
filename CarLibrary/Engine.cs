using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
    public class Engine
    {
        int cylinders;
        double horsepower;

        // Default constructor
        public Engine() : this(4, 100.0)
        {
        }

        // Custom constructor
        public Engine(int cylinders, double horsepower)
        {
            this.cylinders = cylinders;
            this.horsepower = horsepower;
        }

        public void Start()
        {
            Console.WriteLine("Engine started.");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
}
