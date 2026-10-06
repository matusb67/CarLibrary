using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
    public class Car
    {
        string make;
        string model;
        int year;
        Engine engine;

        // Default constructor
        public Car() : this("Unknown", "Unknown", 2000, new Engine())
        {
        }

        // Custom constructor
        public Car(string make, string model, int year, Engine engine)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.engine = engine;
        }

        public void Drive()
        {
            engine.Start();
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            engine.Stop();
            Console.WriteLine("Car stopped.");
        }
    }
}
