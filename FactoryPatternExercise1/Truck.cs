using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternExercise1
{
    internal class Truck : IVehicle
    {
        public string Color { get; set; }
        public bool SnowReady { get; set; }
        public void Drive()
        {
            Console.WriteLine("As a result of your wheel number selection; A truck has been chosen for manufacture.");
            Thread.Sleep(1500); //# of milliseconds the program will count before continuing its loop.
            Console.WriteLine();
            Console.WriteLine($"The {GetType().Name}'s engine is revving up.");
        }
        public void Operation()
        {

        }
    }
}
