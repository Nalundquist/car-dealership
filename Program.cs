using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
	public class Program
	{
		public static void Main ()
		{
			Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 1000, 20, true);
			Car yugo = new Car("1980 Yugo Koral", 700, 56000, 2001, 30, true);
			Car ford = new Car("1988 Ford County Squire", 1400, 239001, 3000, 15, false);
			Car amc = new Car("1976 AMC Pacer", 400, 198000, 1800, 10, false);

			List<Car> Cars = new List<Car>() {volkswagen, yugo, ford, amc};

			Console.WriteLine("Enter maximum price: ");
			string stringMaxPrice = Console.ReadLine();
			int maxPrice = int.Parse(stringMaxPrice);

			List<Car> CarsMatchingSearch = new List<Car>(0);

			foreach (Car automobile in Cars)
			{
				if (automobile.WorthBuying(maxPrice))
				{
					CarsMatchingSearch.Add(automobile);
				}
			}

			foreach(Car automobile in CarsMatchingSearch)
			{
				Console.WriteLine("--------------------");
				Console.WriteLine(automobile.MakeModel);
				Console.WriteLine(automobile.Miles + " miles");
				Console.WriteLine("$" + automobile.Price);
        Console.WriteLine("Sales Price: " + Car.SalePrice(automobile.Price));
				if (Car.DakarRally(automobile.Weight, automobile.Mpg, automobile.Lift) == true)
				{
					Console.WriteLine("Congratulations!  Your car is capable of entering the Dakar Rally.  You have been automatically entered into the Dakar Rally.");
				}
				else
				{
					Console.WriteLine("Condolences.  Your car is unfit for the Dakar Rally.");
				}
			}
		}
	}
}