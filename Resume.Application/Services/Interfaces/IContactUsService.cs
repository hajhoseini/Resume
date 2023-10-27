using Resume.Application.DTOs.SiteSide.ContactUsDTO;

namespace Resume.Application.Services.Interfaces;

public interface IContactUsService
{
	Task AddContactUs(ContactUsDTO contactUsDTO);
}
