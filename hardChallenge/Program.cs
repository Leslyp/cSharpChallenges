using System;

namespace HardChallenge
{
    class Program
    {
		//HARD: Print a Pyramid
        //  *
        // ***
        // *****
        //*******
        //*********
        //Hints: You can use three loops.
        //The big one contains two smaller loops.
        //The first inner loops takes care of the # of spaces.
        //The second inner loop handles the # of stars. 

        static void Main(string[] args)
        {
			string symbol = "*";
			string space = " ";

			for (var i = 0; i < 6; i++)
			{
				// loops that takes care of the # of spaces
                // use i to make loop go while initial for loop is still looping
				for (var j = 5; j > i; j--)
				{
                    Console.Write(space);	
                }
				// loops that takes care of the # of stars
				for (var k = 1; k <= (2 * i - 1); k++)
				{
					Console.Write(symbol);
				}
				Console.WriteLine();
			}
        }
    }
}
