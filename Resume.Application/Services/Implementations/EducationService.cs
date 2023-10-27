using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementations;

public class EducationService : IEducationService
{
    private readonly IEducationRepository _educationRepository;

	public EducationService(IEducationRepository educationRepository)
    {
		_educationRepository = educationRepository;
	}

    public List<Education> GetListOFEducations()
	{
		return _educationRepository.GetListOFEducations();
	}
}
