using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Experience;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;

namespace Resume.Infrastructure.Repository;

public class ExperienceRepository: IExperienceRepository
{
    private readonly ResumeDBContext _context;

    public ExperienceRepository(ResumeDBContext context)
    {
        _context = context;
    }

    public async Task AddExperienceAsync(Experience experience)
    {
        await _context.Experience.AddAsync(experience);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteExperienceAsync(Experience experience)
    {
        _context.Experience.Remove(experience);
        await _context.SaveChangesAsync();
    }

    public async Task EditExperienceAsync(Experience experience)
    {
        _context.Experience.Update(experience);
        await _context.SaveChangesAsync();
    }

    public Task<Experience> GetExperienceByIdAsync(int experienceId)
    {
        return _context.Experience.FirstOrDefaultAsync(p => p.Id == experienceId);
    }

    public List<Experience> GetListOFExperiences()
    {
        return _context.Experience.ToList();
    }
}
