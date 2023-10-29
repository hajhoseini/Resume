using Resume.Application.DTOs.AdminSide.Education;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementations;

public class EducationService : IEducationService
{
    private readonly IEducationRepository _educationRepository;

	public EducationService(IEducationRepository educationRepository)
    {
		_educationRepository = educationRepository;
	}

    public async Task AddEducationAsync(CreateEducationDTO model)
    {
        Education education = new Education()
        {
            EducationTitle = model.EducationTitle,
            EducationDuration = model.EducationDuration,
            Description = model.Description
        };
        await _educationRepository.AddEducationAsync(education);
    }

    public async Task DeleteEducationAsync(EditEducationDTO model)
    {
        Education education = new Education()
        {
            Id = model.Id,
            EducationTitle = model.EducationTitle,
            EducationDuration = model.EducationDuration,
            Description = model.Description
        };
        await _educationRepository.DeleteEducationAsync(education);
    }

    public async Task EditEducationAsync(EditEducationDTO model)
    {
        Education education = new Education()
        {
            Id = model.Id,
            EducationTitle = model.EducationTitle,
            EducationDuration = model.EducationDuration,
            Description = model.Description
        };
        await _educationRepository.EditEducationAsync(education);
    }

    public async Task<EditEducationDTO> GetEducationByIdAsync(int educationId)
    {
        var education = await _educationRepository.GetEducationByIdAsync(educationId);
        EditEducationDTO dto = new EditEducationDTO()
        {
            Id = education.Id,
            EducationTitle = education.EducationTitle,
            EducationDuration = education.EducationDuration,
            Description = education.Description
        };
        
        return dto;
    }

    public List<Education> GetListOFEducations()
	{
		return _educationRepository.GetListOFEducations();
	}
}
