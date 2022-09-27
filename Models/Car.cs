using System;
using System.Collections.Generic;

namespace Dealership.Models
{
	public class Car
	{
		public int MfgYear { get; set; }
		public string MakeModel { get; set; }
		public int Price { get; set; }
		public int Miles { get; set; }
		public int Weight { get; set; }
		public int Mpg { get; set; }
		public bool Lift { get; set; }

		public Car(int mfgYear, string makeModel, int price, int miles, int weight,  int mpg, bool lift )
		{
			MfgYear = mfgYear;
			MakeModel = makeModel;
			Price = price;
			Miles = miles;
			Weight = weight;
			Mpg = mpg;
			Lift = lift;
			_carList.Add(this);
		}

		private static List<Car> _carList = new List<Car> {};

		public static List<Car> GetCars()
		{
			return _carList;
		}



		// public static double SalePrice(int price)
		// {
		// 	return (price) * .43;
		// }

		// public static bool DakarRally(int weight, int mpg, bool lift )
		// {
		// 	if (weight < 2000 && mpg >= 20 && lift == true)
		// 	{
		// 		return true;
		// 	}
		// 	else
		// 	{
		// 		return false;
		// 	}
		// }


		// public bool WorthBuying(int maxPrice)
		// {
		// 	return(Price <= maxPrice);
		// }
	}
}
