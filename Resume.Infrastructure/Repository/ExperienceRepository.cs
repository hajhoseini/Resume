using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Experience;
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

    public async Task AddExperienceAsync(Experience Experience)
    {
        await _context.Experience.AddAsync(Experience);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteExperienceAsync(Experience Experience)
    {
        _context.Experience.Remove(Experience);
        await _context.SaveChangesAsync();
    }

    public async Task EditExperienceAsync(Experience Experience)
    {
        _context.Experience.Update(Experience);
        await _context.SaveChangesAsync();
    }

    public Task<Experience> GetExperienceByIdAsync(int ExperienceId)
    {
        return _context.Experience.FirstOrDefaultAsync(p => p.Id == ExperienceId);
    }

    public List<Experience> GetListOFExperiences()
    {
        return _context.Experience.ToList();
    }
}
