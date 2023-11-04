using Microsoft.AspNetCore.Mvc;

namespace PWS.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
