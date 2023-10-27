using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Resume.Application.DTOs.SiteSide.ContactUsDTO;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Presentation.Controllers
{
	public class ContactUsController : Controller
	{
		private readonly IContactUsRepository _contactUsRepository;

        public ContactUsController(IContactUsRepository contactUsRepository)
        {
			_contactUsRepository = contactUsRepository;				
        }

		[HttpGet]
        public IActionResult ContactUs()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ContactUs(string FullName, string Mobile, string Message)
		{
			ContactUs contactUs = new ContactUs()
			{
				FullName = FullName,
				Mobile = Mobile,
				Message = Message,
				CreateDate = DateTime.Now,
				IsSeenByAdmin = false
			};
			await _contactUsRepository.AddContactUs(contactUs);

			return View();
		}
	}
}
