using Resume.Domain.Entities.ContactUs;

namespace Resume.Domain.RepositoryInterface;

public interface IContactUsRepository
{
	Task AddContactUs(ContactUs contact);
	Task AddContactUsLocation(ContactUsLocation contactUsLocation);
}
