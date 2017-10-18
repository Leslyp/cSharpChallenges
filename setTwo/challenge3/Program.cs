using System;
using System.Collections.Generic;

namespace ChallengeThree
{
    class Program
    {
        static void Main(string[] args)
        {
			// 3. Create a new dictionary called roadtohire that holds yourself, name and age(example "Nancy", 22).
			Dictionary<string, int> roadtohire = new Dictionary<string, int>();

			// Add each student in your class to the dictionary
			roadtohire.Add("Lesly", 18);
            roadtohire.Add("Victoria", 23);
            roadtohire.Add("Malik", 21);
            roadtohire.Add("Ivan", 18);
            roadtohire.Add("Ian", 20);
            roadtohire.Add("Chris", 21);
            roadtohire.Add("Angel", 19);
            roadtohire.Add("Mickey", 19);
            roadtohire.Add("Marcus", 18);
            roadtohire.Add("Hunter", 19);
            roadtohire.Add("Miguel", 21);
            roadtohire.Add("Tia", 23);
			roadtohire.Add("Brittney", 23);
			roadtohire.Add("Juan", 19);
			// as well as a random student, and display your total number of students.
			roadtohire.Add("Randle", 93);
            Console.WriteLine("Total students, including random kid: {0}", roadtohire.Count);

			// Once you have done that remove the random student from your roadtohire dictionary,
			roadtohire.Remove("Randle");
			// and display your current number of students.
			Console.WriteLine("Total students, without random kid: {0}", roadtohire.Count);

            // Finally find yourself in the dictionary and display your name and your age.
            if(roadtohire.ContainsKey("Lesly")) {
                Console.WriteLine("name: Lesly");
                Console.WriteLine("age: {0}", roadtohire["Lesly"]);
			} else{
				Console.WriteLine("Student not found.");
			}
		}
    }
}
