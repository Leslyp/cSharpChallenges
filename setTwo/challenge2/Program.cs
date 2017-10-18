using System;
using ChallengeTwo.Models;

namespace ChallengeTwo
{
    class Program
    {
		//2. Make a class car with the properties numberOfTires = 4, year = 2017, and model = "insert your model of choice",
		//and create three instances of it: car1, car2, and car3.

        static void Main(string[] args)
        {
			Car car1 = new Car();
            Console.WriteLine(car1);

            Car car2 = new Car();
            Console.WriteLine(car2);

            Car car3 = new Car();
            Console.WriteLine(car3);
        }
    }
}
