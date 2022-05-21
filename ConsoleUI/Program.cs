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

            #region Vehicles

            

            var vehicle = new List<Vehicle>();

            //  DONE Create a list of Vehicle called vehicles

            Car buick = new Car() { HasTrunk = true, Make = "Buick", Model = "Encore", Year = 2017 };
            Motorcycle sportster = new Motorcycle() { HasSideCart = false, Make = "Harley", Model = "Sportster XL 1200", Year = 2007 };
            Vehicle electricCar = new Car() { HasTrunk = true, Make = "Rivian", Model = "R1T", Year = 2022 };
            Vehicle firstCar = new Car() { HasTrunk = true, Make = "Oldsmobile", Model = "Achiva", Year = 1996 };
            /*
             * DONE Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * DONE Add the 4 vehicles to the list
             *  DONE Using a foreach loop iterate over each of the properties
             */
            vehicle.Add(buick);
            vehicle.Add(sportster);
            vehicle.Add(electricCar);
            vehicle.Add(firstCar);

            foreach (var veh in vehicle)
            {
                Console.WriteLine($"Make: {veh.Make}");
                Console.WriteLine($"Model: {veh.Model}");
                Console.WriteLine($"Year: {veh.Year}");
                veh.DriveAbstract();
                Console.WriteLine("-------------------");
            }

            //  DONE Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
