using Resume.Domain.Entities.Experience;

namespace Resume.Domain.RepositoryInterface;

public interface IExperienceRepository
{
	List<Experience> GetListOFExperiences();
}
