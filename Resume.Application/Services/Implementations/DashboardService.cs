using Resume.Application.DTOs.SiteSide.Home;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;

namespace Resume.Application.Services.Implementations;

public class DashboardService : IDashboardService
{
	private readonly IEducationService _educationService;
	private readonly IExperienceService _experienceService;
	private readonly IMySkillsService _mySkillsService;

	public DashboardService(IEducationService educationService,
						  IExperienceService experienceService,
						  IMySkillsService mySkillsService)
	{
		_educationService = educationService;
		_experienceService = experienceService;
		_mySkillsService = mySkillsService;
	}

	public async Task<HomeIndexModelDTO> FillDashboardModel()
	{
		List<Education> educations = _educationService.GetListOFEducations();
		List<Experience> experiences = _experienceService.GetListOFExperiences();
		List<MySkills> mySkills = _mySkillsService.GetListOFMySkills();

		HomeIndexModelDTO dto = new HomeIndexModelDTO()
		{
			Educations = educations,
			Experiences = experiences,
			MySkills = mySkills
		};

		return dto;
	}
}
