using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;
using System.Collections.Generic;

namespace Resume.Infrastructure.Repository;

public class EducationRepository : IEducationRepository
{
	private readonly ResumeDBContext _context;

	public EducationRepository(ResumeDBContext context)
	{
		_context = context;
	}

	public List<Education> GetListOFEducations()
	{
		return _context.Education.ToList();
	}
}
