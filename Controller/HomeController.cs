using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet ("/")]
		public ActionResult Index() { return View(); }
	}
}