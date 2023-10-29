using Resume.Domain.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface;

public interface IMySkillsRepository
{
	List<MySkills> GetListOFMySkills();

    Task AddMySkillsAsync(MySkills mySkills);

    Task<MySkills> GetMySkillsByIdAsync(int mySkillsId);

    Task EditMySkillsAsync(MySkills mySkills);

    Task DeleteMySkillsAsync(MySkills mySkills);
}
