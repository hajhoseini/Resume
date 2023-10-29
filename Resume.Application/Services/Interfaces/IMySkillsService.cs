using Resume.Application.DTOs.AdminSide.MySkills;
using Resume.Domain.Entities.MySkills;

namespace Resume.Application.Services.Interfaces;

public interface IMySkillsService
{
    List<MySkills> GetListOFMySkills();

    Task AddMySkillsAsync(CreateMySkillsDTO model);

    Task<EditMySkillsDTO> GetMySkillsByIdAsync(int MySkillsId);

    Task EditMySkillsAsync(EditMySkillsDTO model);

    Task DeleteMySkillsAsync(EditMySkillsDTO model);
}
