using System;
using System.Collections.Generic;

namespace Dealership.Models
{
	public class Car
	{
		public string MakeModel { get; set; }
		public int Price { get; set; }
		public int Miles { get; set; }
		public int Weight { get; set; }
		public int Mpg { get; set; }
		public bool Lift { get; set; }

		public Car(string makeModel, int price, int miles, int weight,  int mpg, bool lift )
		{
			MakeModel = makeModel;
			Price = price;
			Miles = miles;
			Weight = weight;
			Mpg = mpg;
			Lift = lift;
			_carList.Add(this);
		}

		Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 1000, 20, true);
		Car yugo = new Car("1980 Yugo Koral", 700, 56000, 2001, 30, true);
		Car ford = new Car("1988 Ford County Squire", 1400, 239001, 3000, 15, false);
		Car amc = new Car("1976 AMC Pacer", 400, 198000, 1800, 10, false);

		private List<Car> _carList = new List<Car> {volkswagen, yugo, ford, amc};

		public List<Car> GetCars()
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
