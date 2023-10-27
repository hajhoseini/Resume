using Resume.Domain.Entities.Education;

namespace Resume.Domain.RepositoryInterface;

public interface IEducationRepository
{
	List<Education> GetListOFEducations();
}
