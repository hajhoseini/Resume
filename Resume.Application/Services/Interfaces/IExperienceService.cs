using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;

namespace Resume.Application.Services.Interfaces;

public interface IExperienceService
{
	List<Experience> GetListOFExperiences();
}
