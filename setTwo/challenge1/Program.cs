using System;

namespace ChallengeOne
{
    class Program
    {
        //1. Write a method that divides two numbers(provided as parameters).
        //Tip: you will need to use the modifiers public and static. Do not hardcode the two numbers
        public static double Divide(double num1, double num2) 
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            var inputOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter another integer:");
            var inputTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The qoutient of {0} divded by {1} is {2} ", inputOne, inputTwo, Divide(inputOne, inputTwo)); 
        }
    }
}
