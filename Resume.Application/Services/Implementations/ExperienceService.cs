using Resume.Application.DTOs.AdminSide.Experience;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.Experience;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementations;

public class ExperienceService : IExperienceService
{
    private readonly IExperienceRepository _ExperienceRepository;

    public ExperienceService(IExperienceRepository ExperienceRepository)
    {
        _ExperienceRepository = ExperienceRepository;
    }

    public async Task AddExperienceAsync(CreateExperienceDTO model)
    {
        Experience Experience = new Experience()
        {
            ExperienceTitle = model.ExperienceTitle,
            ExperienceDuration = model.ExperienceDuration,
            CompanyName = model.CompanyName,
            CompanySite = model.CompanySite,
            Description = model.Description
        };
        await _ExperienceRepository.AddExperienceAsync(Experience);
    }

    public async Task DeleteExperienceAsync(EditExperienceDTO model)
    {
        Experience Experience = new Experience()
        {
            Id = model.Id,
            ExperienceTitle = model.ExperienceTitle,
            ExperienceDuration = model.ExperienceDuration,
            CompanyName = model.CompanyName,
            CompanySite = model.CompanySite,
            Description = model.Description
        };
        await _ExperienceRepository.DeleteExperienceAsync(Experience);
    }

    public async Task EditExperienceAsync(EditExperienceDTO model)
    {
        Experience Experience = new Experience()
        {
            Id = model.Id,
            ExperienceTitle = model.ExperienceTitle,
            ExperienceDuration = model.ExperienceDuration,
            CompanyName = model.CompanyName,
            CompanySite = model.CompanySite,
            Description = model.Description
        };
        await _ExperienceRepository.EditExperienceAsync(Experience);
    }

    public async Task<EditExperienceDTO> GetExperienceByIdAsync(int ExperienceId)
    {
        var Experience = await _ExperienceRepository.GetExperienceByIdAsync(ExperienceId);
        EditExperienceDTO dto = new EditExperienceDTO()
        {
            Id = Experience.Id,
            ExperienceTitle = Experience.ExperienceTitle,
            ExperienceDuration = Experience.ExperienceDuration,
            CompanyName = Experience.CompanyName,
            CompanySite = Experience.CompanySite,
            Description = Experience.Description
        };

        return dto;
    }

    public List<Experience> GetListOFExperiences()
    {
        return _ExperienceRepository.GetListOFExperiences();
    }
}
