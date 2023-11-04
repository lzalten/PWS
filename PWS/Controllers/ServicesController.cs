using Microsoft.AspNetCore.Mvc;

namespace PWS.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
