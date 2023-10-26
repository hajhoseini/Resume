namespace Resume.Domain.Entities.Education;

public class Education
{
    #region properties

    public int Id { get; set; }

    public string EducationTitle { get; set; }

    public string EducationDuration { get; set; }

    public string? Description { get; set; }

    #endregion
}
