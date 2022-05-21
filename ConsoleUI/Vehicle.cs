using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model"; 

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is in drive and its FAST!");
        }


        /*
       * Create an abstract class called Vehicle DONE
       * The vehicle class shall have three string properties Year, Make, and Model DONE
       * Set the defaults to something generic in the Vehicle class DONE
       * Vehicle shall have an abstract method called DriveAbstract with no implementation DONE
       * Vehicle shall have a virtual method called DriveVirtual with a base implementation. DONE
       */
    }
}
