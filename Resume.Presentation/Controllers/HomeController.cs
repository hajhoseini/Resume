using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.Home;
using Resume.Application.Services.Interfaces;

namespace Resume.Presentation.Controllers
{
	public class HomeController : Controller
	{
		private readonly IDashboardService _dashboardService;

        public HomeController(IDashboardService dashboardService)
        {
			_dashboardService = dashboardService;
        }

		public async Task<IActionResult> Index()
		{
			HomeIndexModelDTO dto = await _dashboardService.FillDashboardModel();
			return View(dto);
		}

		public IActionResult Privacy()
		{
			return View();
		}
	}
}