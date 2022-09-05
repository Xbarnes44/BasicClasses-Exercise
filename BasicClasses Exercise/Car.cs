using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses_Exercise
{
    public class Car
    {

        public Car(string make, string model, int year)
        {

        }
        public Car()
        {

        }

        // Create a MAKE property of type string that is public 
        public string Make { get; set; } // get= read, set = write

        public string Model { get; set; }

        public int Year { get; set; }   
    }
}
