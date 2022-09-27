using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Models.Controllers
{
	public class CarsController : Controller
	{
		[HttpGet ("/cars")]
		public ActionResult Cars() 
		{ 
			List<Car> carList = Car.GetCars();
			return View(carList); 
		}

		[HttpGet ("/cars/add")]
		public ActionResult AddCar()
		{
			return View();
		}

		[HttpPost("/cars")]
		public ActionResult Add(int year, string make, int price, int miles, int weight, int mpg, bool lift)
		{
			Car car = new Car(year, make, price, miles, weight, mpg, lift);
			return RedirectToAction("Cars");
		}
	}
}