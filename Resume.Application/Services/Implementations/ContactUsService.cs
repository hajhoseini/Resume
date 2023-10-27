using Resume.Application.DTOs.SiteSide.ContactUsDTO;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementations;

public class ContactUsService : IContactUsService
{
	private readonly IContactUsRepository _contactUsRepository;

	public ContactUsService(IContactUsRepository contactUsRepository)
	{
		_contactUsRepository = contactUsRepository;
	}

	public async Task AddContactUs(ContactUsDTO contactUsDTO)
	{
		ContactUs contactUs = new ContactUs()
		{
			FullName = contactUsDTO.FullName,
			Mobile = contactUsDTO.Mobile,
			Message = contactUsDTO.Message,
			CreateDate = DateTime.Now,
			IsSeenByAdmin = false
		};

		ContactUsLocation contactUsLocation = new ContactUsLocation()
		{
			Address = contactUsDTO.Address,
		};

		await _contactUsRepository.AddContactUs(contactUs);
		await _contactUsRepository.AddContactUsLocation(contactUsLocation);
	}
}
