using System;

namespace MediumChallenge
{
    class Program
    {
        //MEDIUM: Write a loop that would print out the following: 
        //********** 
        //********** 
        //********** 
        //********** 
        //**********   
        //You can only have the ' * ' character once!

        static void Main(string[] args)
        {
            string symbol = "*";

            int numberOfLoops = 5;

            int numberOfSymbols = 10;

            for (var i = 0; i < numberOfLoops; i++) 
            {
                for (var j = 0; j < numberOfSymbols; j++)
                {
                    Console.Write(symbol);
                }

				Console.WriteLine();

			}
        }


    }
}
