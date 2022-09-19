using System;

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

		public static double SalePrice(int price)
		{
			return (price) * .43;
		}

		public static bool DakarRally(int weight, int mpg, bool lift )
		{
			if (weight < 2000 && mpg >= 20 && lift == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public Car(string makeModel, int price, int miles, int weight,  int mpg, bool lift )
		{
			MakeModel = makeModel;
			Price = price;
			Miles = miles;
			Weight = weight;
			Mpg = mpg;
			Lift = lift;
		}

		public bool WorthBuying(int maxPrice)
		{
			return(Price <= maxPrice);
		}
	}
}
