using Resume.Domain.Entities.Experience;

namespace Resume.Domain.RepositoryInterface;

public interface IExperienceRepository
{
    List<Experience> GetListOFExperiences();

    Task AddExperienceAsync(Experience experience);

    Task<Experience> GetExperienceByIdAsync(int experienceId);

    Task EditExperienceAsync(Experience experience);

    Task DeleteExperienceAsync(Experience experience);
}
