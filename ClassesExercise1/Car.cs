using System;
namespace ClassesExercise1
{
	public class Car
	{
		public Car()
		{
            
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        //YOU HAVE THE OPTION TO USE
        //FIELDS
        //PROPERTIES
        //METHODS
        //create a Make property of type string that is public 
        //PROPERTIES
        public string Make {get; set;}
        public string Model {get; set;}
		public int Year {get; set;}
	}
}
