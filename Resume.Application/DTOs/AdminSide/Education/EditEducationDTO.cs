using System.ComponentModel.DataAnnotations;

namespace Resume.Application.DTOs.AdminSide.Education;

public class EditEducationDTO
{
    public int Id { get; set; }

    [Required]
    public string EducationTitle { get; set; }

    [Required]
    public string EducationDuration { get; set; }

    [Required]
    public string? Description { get; set; }
}
