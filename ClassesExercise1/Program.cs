using System;
using System.Collections.Generic;

namespace ClassesExercise1
{   //within class I create a main method array 
    class Program
    {
        static void Main(string[] args)
        {//I choose which method to create the blueprint of the instance..dot notation ..??
            Car car1 = new Car();
            car1.Make = "Dodge";
            car1.Model = "Challenger";
            car1.Year = 2018;
            //initializer...
            var honda = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Year = 2020
            };

            var porcha = new Car("Porcha", "911", 2022);
            //then I create a new list to then call..
            var carList = new List<Car>() { car1, honda, porcha }; ;
            foreach (var item in carList)
            {
                Console.WriteLine($"{item.Make} {item.Model} {item.Year}");
      
            }
        }
        
            
    }
}

