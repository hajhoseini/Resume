using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;

namespace Resume.Infrastructure.Repository;

public class MySkillsRepository: IMySkillsRepository
{
	private readonly ResumeDBContext _context;

	public MySkillsRepository(ResumeDBContext context)
	{
		_context = context;
	}

	public List<MySkills> GetListOFMySkills()
	{
		return _context.MySkills.ToList();
	}
}
