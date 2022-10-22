using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternExercise1
{
    internal class Boat : IVehicle
    {
        public string Color { get; set; }
        public bool WaterOnly { get; set; }
        public void Drive()
        {
            Console.WriteLine("As a result of your wheel number selection; A boat has been chosen for manufacture.");
            Thread.Sleep(1500); //# of milliseconds the program will count before continuing its loop.
            Console.WriteLine();
            Console.WriteLine($"The {GetType().Name}'s engine is revving up.");
        }
        public void Operation() //we created something else that the interface class wanted us to pass in its derived classes, but as you can see, it doesn't care what we do with it -- left it blank just for kicks.
        {

        }
    }
}
