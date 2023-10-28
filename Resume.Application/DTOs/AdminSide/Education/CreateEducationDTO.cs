using System.ComponentModel.DataAnnotations;

namespace Resume.Application.DTOs.AdminSide.Education;

public class CreateEducationDTO
{
    [Required]
    public string EducationTitle { get; set; }

    [Required]
    public string EducationDuration { get; set; }

    [Required]
    public string? Description { get; set; }
}
