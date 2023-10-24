using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(string email, string password)
		{
			return View();
		}
	}
}
