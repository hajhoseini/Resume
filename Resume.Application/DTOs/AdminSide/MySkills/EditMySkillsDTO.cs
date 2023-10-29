using System.ComponentModel.DataAnnotations;

namespace Resume.Application.DTOs.AdminSide.MySkills;

public class EditMySkillsDTO
{
    public int Id { get; set; }

    [Required]
    public string SkillTitle { get; set; }

    [Required]
    public int Percentage { get; set; }
}
