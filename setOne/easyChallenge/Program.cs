using System;

namespace EasyChallenge
{
    class Program
    {
		//EASY: Create a program that asks the user to enter an integer.If the integer is less than 10, print the message "This number is too small". If the integer is greater than or equal to 10, print "This number is big enough".  
        //Hint: read a line and then use Int32.TryParse() to convert the text to an integer.
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");

                    int userInput = Convert.ToInt16(Console.ReadLine());

                    int number = 10;
                    // let user know their stats
                    if (userInput >= number)
                    {
                        Console.WriteLine("This number is big enough.");
                        break;
                    }
                    else if (userInput < number)
                    {
                        Console.WriteLine("This number is too small.");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You must enter a valid number");
                }
            }
        }
    }
}
