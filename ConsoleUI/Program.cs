using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            var vehicles = new List<Vehicle>();

            var dart = new Car() { HasTrunk = true, Make = "Dodge", Model = "Dart", Year = 2014 };
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "Honda", Model = "Goldwing", Year = 2020 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2018 };
            Vehicle fourdoor = new Car() { HasTrunk = false, Make = "UFO", Model = "unknown", Year = 3022 };

            vehicles.Add(dart);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(fourdoor);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model}, Year {veh.Year}");
                veh.DriveAbstract();
                Console.WriteLine("------------");
            }


        }
    }
}


// Create a list of Vehicle called vehicles


//Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
//- new it up as one of each derived class
//Set the properties with object initializer syntax//