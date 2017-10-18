using System;
using ChallengeFour.Models;

namespace ChallengeFour
{
    class Program
    {
        // 4. Make a class Vehicle with the properties Type, NumberOfTires, Year, and Model.
        // Then write a constructor that takes in those 4 properties as parameters and sets the values of the properties.
        // Once your constructor is complete create two instances of Vehicle,
        // the first one should be your dream car,
        // the second should be your i would hate car.
        // Finally display the model of your dream car and the model of your hate car.
        static void Main(string[] args)
        {
			// Call the constructor 
            Vehicle dreamCar = new Vehicle("Convertible", 4, 1999, "Beetle");
            Console.WriteLine("The model of my dream car is a {0}", dreamCar.model);

			Vehicle hateCar = new Vehicle("Sedan", 4, 2016, "Camry");
            Console.WriteLine("The model of my hate car is a {0}", hateCar.model);
        }
    }
}
