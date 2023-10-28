using Resume.Application.DTOs.AdminSide.Education;
using Resume.Domain.Entities.Education;

namespace Resume.Application.Services.Interfaces;

public interface IEducationService
{
	List<Education> GetListOFEducations();

    Task AddEducationAsync(CreateEducationDTO model);

    Task<EditEducationDTO> GetEducationByIdAsync(int educationId);

    Task EditEducationAsync(EditEducationDTO model);

    Task DeleteEducationAsync(EditEducationDTO model);
}
