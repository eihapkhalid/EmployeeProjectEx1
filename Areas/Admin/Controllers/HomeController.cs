﻿using Microsoft.AspNetCore.Mvc;

namespace EmployeeProjectEx.Areas.Admin.Controllers
{
	[Area("admin")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
