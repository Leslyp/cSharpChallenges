using System;
namespace ChallengeFour.Models
{
    public class Vehicle
    {
        public string type; 
        public int numberOfTires;
    	public int year;
    	public string model;

		// Constructor that takes four arguments
        public Vehicle(string ty, int numTires, int yr, string mod)
		{
            type = ty;
            numberOfTires = numTires;
            year = yr;
            model = mod;
		}
    }
}
