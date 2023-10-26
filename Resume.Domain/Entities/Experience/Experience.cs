namespace Resume.Domain.Entities.Experience;

public class Experience
{
    #region properties

    public int Id { get; set; }

    public string ExperienceTitle { get; set; }

    public string ExperienceDuration { get; set; }

    public string Description { get; set; }

    public string CompanyName { get; set; }

    public string? CompanySite { get; set; }

    #endregion
}
