using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("VROOOOOOOOM!! VROOOOOOOOM!!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is a {GetType().BaseType.Name} is in drive and its FAST!");
        }
        /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
    }
}
