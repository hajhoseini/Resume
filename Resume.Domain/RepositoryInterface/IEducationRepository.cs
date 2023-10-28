using Resume.Domain.Entities.Education;

namespace Resume.Domain.RepositoryInterface;

public interface IEducationRepository
{
	List<Education> GetListOFEducations();

    Task AddEducationAsync(Education education);

    Task<Education> GetEducationByIdAsync(int educationId);

    Task EditEducationAsync(Education education);

    Task DeleteEducationAsync(Education education);
}
