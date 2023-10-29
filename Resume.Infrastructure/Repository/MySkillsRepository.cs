using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;

namespace Resume.Infrastructure.Repository;

public class MySkillsRepository: IMySkillsRepository
{
    private readonly ResumeDBContext _context;

    public MySkillsRepository(ResumeDBContext context)
    {
        _context = context;
    }

    public async Task AddMySkillsAsync(MySkills mySkills)
    {
        await _context.MySkills.AddAsync(mySkills);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMySkillsAsync(MySkills mySkills)
    {
        _context.MySkills.Remove(mySkills);
        await _context.SaveChangesAsync();
    }

    public async Task EditMySkillsAsync(MySkills mySkills)
    {
        _context.MySkills.Update(mySkills);
        await _context.SaveChangesAsync();
    }

    public List<MySkills> GetListOFMySkills()
    {
        return _context.MySkills.ToList();
    }

    public Task<MySkills> GetMySkillsByIdAsync(int mySkillsId)
    {
        return _context.MySkills.FirstOrDefaultAsync(p => p.Id == mySkillsId);
    }
}
