using BasicClasses_Exercise;
using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car(); // Constuctor - special member method. Helps us create a new instance of the Car class
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2008;

            var mazda = new Car()
            {
                Make = "Mazda" ,
                Model = "Cx-5" ,
                Year = 2016
            };

            var chevy = new Car("Chevy", "Impala", 2001)
            {

            };

        }
    }
}