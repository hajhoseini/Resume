using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementations;

public class MySkillsService : IMySkillsService
{
	private readonly IMySkillsRepository _mySkillsRepository;

    public MySkillsService(IMySkillsRepository mySkillsRepository)
    {
		_mySkillsRepository = mySkillsRepository;
    }

    public List<MySkills> GetListOFMySkills()
	{
		return _mySkillsRepository.GetListOFMySkills();
	}
}
