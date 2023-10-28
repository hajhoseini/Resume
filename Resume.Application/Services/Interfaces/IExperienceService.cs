using Resume.Application.DTOs.AdminSide.Experience;
using Resume.Domain.Entities.Experience;

namespace Resume.Application.Services.Interfaces;

public interface IExperienceService
{
    List<Experience> GetListOFExperiences();

    Task AddExperienceAsync(CreateExperienceDTO model);

    Task<EditExperienceDTO> GetExperienceByIdAsync(int experienceId);

    Task EditExperienceAsync(EditExperienceDTO model);

    Task DeleteExperienceAsync(EditExperienceDTO model);
}
