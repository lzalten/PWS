﻿using Microsoft.AspNetCore.Mvc;

namespace IvanL.Controllers
{
    public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
