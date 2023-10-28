using Resume.Domain.Entities.Experience;

namespace Resume.Domain.RepositoryInterface;

public interface IExperienceRepository
{
    List<Experience> GetListOFExperiences();

    Task AddExperienceAsync(Experience Experience);

    Task<Experience> GetExperienceByIdAsync(int ExperienceId);

    Task EditExperienceAsync(Experience Experience);

    Task DeleteExperienceAsync(Experience Experience);
}
