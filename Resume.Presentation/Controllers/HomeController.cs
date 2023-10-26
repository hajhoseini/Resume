using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.Home;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;
using Resume.Infrastructure.DBContext;

namespace Resume.Presentation.Controllers
{
	public class HomeController : Controller
	{
		private readonly ResumeDBContext _context;

        public HomeController(ResumeDBContext context)
        {
			_context = context;
        }

		public IActionResult Index()
		{
			List<Education> educations = _context.Education.ToList();
			List<Experience> experiences = _context.Experience.ToList();
			List<MySkills> mySkills = _context.MySkills.ToList();

			HomeIndexModelDTO dto = new HomeIndexModelDTO()
			{
				Educations = educations,
				Experiences = experiences,
				MySkills = mySkills
			};


			return View(dto);
		}

		public IActionResult Privacy()
		{
			return View();
		}
	}
}