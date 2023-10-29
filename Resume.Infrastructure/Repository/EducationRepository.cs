using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;

namespace Resume.Infrastructure.Repository;

public class EducationRepository : IEducationRepository
{
	private readonly ResumeDBContext _context;

	public EducationRepository(ResumeDBContext context)
	{
		_context = context;
	}

    public async Task AddEducationAsync(Education education)
    {
        await _context.Education.AddAsync(education);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEducationAsync(Education education)
    {
        _context.Education.Remove(education);
        await _context.SaveChangesAsync();
    }

    public async Task EditEducationAsync(Education education)
    {
        _context.Education.Update(education);
        await _context.SaveChangesAsync();
    }

    public Task<Education> GetEducationByIdAsync(int educationId)
    {
        return _context.Education.FirstOrDefaultAsync(p => p.Id == educationId);
    }

    public List<Education> GetListOFEducations()
	{
		return _context.Education.ToList();
	}
}
