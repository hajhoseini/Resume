using System.ComponentModel.DataAnnotations;

namespace Resume.Application.DTOs.AdminSide.MySkills;

public class CreateMySkillsDTO
{
    [Required]
    public string SkillTitle { get; set; }

    [Required]
    public int Percentage { get; set; }
}
