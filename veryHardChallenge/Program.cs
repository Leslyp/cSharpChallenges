using System;

namespace VeryHardChallenge
{
    //VERY HARD:  
    //Write a program using a switch statement that takes one value from the user and asks about the type of conversion and then performs a conversion depending on the type of conversion.
    //If user enters: 
    //I -> convert from inches to centimeters.
    //G -> convert from gallons to liters.
    //M -> convert from mile to kilometer.
    //P -> convert from pound to kilogram.
    //If the user enters any other character then show a proper message.

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
				Console.WriteLine("Enter a number: ");
				int inputNumber = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter a type of conversion: ");
				string conversion = Console.ReadLine();
                string inputType = conversion.ToUpper();

                var inches = (inputNumber * 2.54);
				var gallons = (inputNumber * 3.785);
				var miles = (inputNumber * 1.609);
				var pounds = (inputNumber * .454);

				switch (inputType)
				{
					case "I":
                        Console.WriteLine("{0} in inches is equal to {1} centmeters", inputType, inches);
						break;
					case "G":
						Console.WriteLine("{0} in gallons is equal to {1} liters", inputType, gallons);
						break;
                    case "M":
						Console.WriteLine("{0} in miles is equal to {1} kilometers", inputType, miles);
                        break;
					case "P":
						Console.WriteLine("{0} in pounds is equal to {1} kilograms", inputType, pounds);
						break;
                    default:
						Console.WriteLine("Error, please type in a proper conversion type.");
						break;
				}
            } catch(Exception) {
                Console.WriteLine("ERROR");
            }

        }
    }
}
