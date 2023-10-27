using Resume.Domain.Entities.Education;

namespace Resume.Application.Services.Interfaces;

public interface IEducationService
{
	List<Education> GetListOFEducations();
}
