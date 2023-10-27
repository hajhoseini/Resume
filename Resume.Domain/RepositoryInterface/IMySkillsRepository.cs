using Resume.Domain.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface;

public interface IMySkillsRepository
{
	List<MySkills> GetListOFMySkills();
}
