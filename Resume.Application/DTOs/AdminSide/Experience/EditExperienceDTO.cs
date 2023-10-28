﻿namespace Resume.Application.DTOs.AdminSide.Experience;

public class EditExperienceDTO
{    
    public int Id { get; set; }

    public string ExperienceTitle { get; set; }

    public string ExperienceDuration { get; set; }

    public string Description { get; set; }

    public string CompanyName { get; set; }

    public string? CompanySite { get; set; }
}
