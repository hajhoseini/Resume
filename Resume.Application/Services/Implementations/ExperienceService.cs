using Resume.Application.DTOs.AdminSide.Experience;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.Experience;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementations;

public class ExperienceService : IExperienceService
{
    private readonly IExperienceRepository _experienceRepository;

    public ExperienceService(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task AddExperienceAsync(CreateExperienceDTO model)
    {
        Experience experience = new Experience()
        {
            ExperienceTitle = model.ExperienceTitle,
            ExperienceDuration = model.ExperienceDuration,
            CompanyName = model.CompanyName,
            CompanySite = model.CompanySite,
            Description = model.Description
        };
        await _experienceRepository.AddExperienceAsync(experience);
    }

    public async Task DeleteExperienceAsync(EditExperienceDTO model)
    {
        Experience experience = new Experience()
        {
            Id = model.Id,
            ExperienceTitle = model.ExperienceTitle,
            ExperienceDuration = model.ExperienceDuration,
            CompanyName = model.CompanyName,
            CompanySite = model.CompanySite,
            Description = model.Description
        };
        await _experienceRepository.DeleteExperienceAsync(experience);
    }

    public async Task EditExperienceAsync(EditExperienceDTO model)
    {
        Experience experience = new Experience()
        {
            Id = model.Id,
            ExperienceTitle = model.ExperienceTitle,
            ExperienceDuration = model.ExperienceDuration,
            CompanyName = model.CompanyName,
            CompanySite = model.CompanySite,
            Description = model.Description
        };
        await _experienceRepository.EditExperienceAsync(experience);
    }

    public async Task<EditExperienceDTO> GetExperienceByIdAsync(int experienceId)
    {
        var experience = await _experienceRepository.GetExperienceByIdAsync(experienceId);
        EditExperienceDTO dto = new EditExperienceDTO()
        {
            Id = experience.Id,
            ExperienceTitle = experience.ExperienceTitle,
            ExperienceDuration = experience.ExperienceDuration,
            CompanyName = experience.CompanyName,
            CompanySite = experience.CompanySite,
            Description = experience.Description
        };

        return dto;
    }

    public List<Experience> GetListOFExperiences()
    {
        return _experienceRepository.GetListOFExperiences();
    }
}
