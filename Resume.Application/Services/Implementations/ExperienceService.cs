using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.Experience;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementations;

public class ExperienceService : IExperienceService
{
	private readonly IExperienceRepository _experienceRepository;

    public ExperienceService(IExperienceRepository experienceRepository)
    {
		_experienceRepository = experienceRepository;
	}

    public List<Experience> GetListOFExperiences()
	{
		return _experienceRepository.GetListOFExperiences();
	}
}
