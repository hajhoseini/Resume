using Resume.Application.DTOs.AdminSide.MySkills;
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

    public async Task AddMySkillsAsync(CreateMySkillsDTO model)
    {
        MySkills mySkills = new MySkills()
        {
            SkillTitle = model.SkillTitle,
            Percentage = model.Percentage            
        };
        await _mySkillsRepository.AddMySkillsAsync(mySkills);
    }

    public async Task DeleteMySkillsAsync(EditMySkillsDTO model)
    {
        MySkills mySkills = new MySkills()
        {
            Id = model.Id,
            SkillTitle = model.SkillTitle,
            Percentage = model.Percentage
        };
        await _mySkillsRepository.DeleteMySkillsAsync(mySkills);
    }

    public async Task EditMySkillsAsync(EditMySkillsDTO model)
    {
        MySkills mySkills = new MySkills()
        {
            Id = model.Id,
            SkillTitle = model.SkillTitle,
            Percentage = model.Percentage
        };
        await _mySkillsRepository.EditMySkillsAsync(mySkills);
    }

    public async Task<EditMySkillsDTO> GetMySkillsByIdAsync(int mySkillsId)
    {
        var mySkills = await _mySkillsRepository.GetMySkillsByIdAsync(mySkillsId);
        EditMySkillsDTO dto = new EditMySkillsDTO()
        {
            Id = mySkills.Id,
            SkillTitle = mySkills.SkillTitle,
            Percentage = mySkills.Percentage            
        };

        return dto;
    }

    public List<MySkills> GetListOFMySkills()
    {
        return _mySkillsRepository.GetListOFMySkills();
    }
}
