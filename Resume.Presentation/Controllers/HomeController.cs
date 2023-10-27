using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.Home;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;

namespace Resume.Presentation.Controllers
{
	public class HomeController : Controller
	{
		private readonly IEducationRepository _educationRepository;
		private readonly IExperienceRepository _experienceRepository;
		private readonly IMySkillsRepository _mySkillsRepository;

        public HomeController(IEducationRepository educationRepository, IExperienceRepository experienceRepository, IMySkillsRepository mySkillsRepository)
        {
			_educationRepository = educationRepository;
			_experienceRepository = experienceRepository;
			_mySkillsRepository = mySkillsRepository;
        }

		public IActionResult Index()
		{
			List<Education> educations = _educationRepository.GetListOFEducations();
			List<Experience> experiences = _experienceRepository.GetListOFExperiences();
			List<MySkills> mySkills = _mySkillsRepository.GetListOFMySkills();

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