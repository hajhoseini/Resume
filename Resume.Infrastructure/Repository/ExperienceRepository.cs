using Resume.Domain.Entities.Experience;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;

namespace Resume.Infrastructure.Repository;

public class ExperienceRepository: IExperienceRepository
{
	private readonly ResumeDBContext _context;

	public ExperienceRepository(ResumeDBContext context)
	{
		_context = context;
	}

	public List<Experience> GetListOFExperiences()
	{
		return _context.Experience.ToList();
	}
}
