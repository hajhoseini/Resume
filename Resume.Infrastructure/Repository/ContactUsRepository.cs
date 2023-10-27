using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;

namespace Resume.Infrastructure.Repository;

public class ContactUsRepository : IContactUsRepository
{
	private readonly ResumeDBContext _context;

	public ContactUsRepository(ResumeDBContext Context)
	{
		_context = Context;
	}

	public async Task AddContactUs(ContactUs contact)
	{
		await _context.ContactUs.AddAsync(contact);
		await _context.SaveChangesAsync();
	}
}
