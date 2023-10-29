using System.ComponentModel.DataAnnotations;

namespace Resume.Application.DTOs.AdminSide.Experience;

public class CreateExperienceDTO
{
    [Required]
    public string ExperienceTitle { get; set; }

    [Required]
    public string ExperienceDuration { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string? CompanySite { get; set; }
}
