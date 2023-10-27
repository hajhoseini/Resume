using Resume.Domain.Entities.MySkills;

namespace Resume.Application.Services.Interfaces;

public interface IMySkillsService
{
	List<MySkills> GetListOFMySkills();
}
