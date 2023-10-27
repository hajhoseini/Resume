using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Resume.Application.DTOs.SiteSide.ContactUsDTO;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Presentation.Controllers
{
	public class ContactUsController : Controller
	{
		private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
			_contactUsService = contactUsService;				
        }

		[HttpGet]
        public IActionResult ContactUs()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDTO)
		{			
			await _contactUsService.AddContactUs(contactUsDTO);		
			//return View();
			return RedirectToAction("Index", "Home");
		}
	}
}
