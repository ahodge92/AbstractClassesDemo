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

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car myCar = new Car()
            {
                HasTrunk = true,
                Make = "Honda",
                Model = "Fit",
                Year = 2010

            };

            Motorcycle myMoto = new Motorcycle()
            {
                HasSideCart = false,
                Make = "HD",
                Model = "Chopper",
                Year = 1978

            };

            Vehicle sedan = new Car()
            {
                Make = "Dodge",
                Model = "Plymoth",
                Year = 1992
            };

            Vehicle sport = new Car()
            {
                HasTrunk = false,
                Make = "Chevrolet",
                Model = "Corvette",
                Year = 1978
            };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(myCar);
            vehicles.Add(myMoto);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"Make: {item.Make} Model: {item.Model} Year: {item.Year}");
                item.DriveVirtual();
                Console.WriteLine("---------------------------------------------");
    

            }

            // Call each of the drive methods for one car and one motorcycle

            Console.ReadLine();
        }
    }
}
