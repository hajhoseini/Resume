using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.AdminSide.Education;
using Resume.Application.Services.Interfaces;

namespace Resume.Presentation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class EducationController : Controller
{
    private readonly IEducationService _educationService;

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var model = _educationService.GetListOFEducations();
        return View(model);
    }    

    [HttpGet]
    public IActionResult CreateEducation()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateEducation(CreateEducationDTO model)
    {
        if (ModelState.IsValid)
        {
            await _educationService.AddEducationAsync(model);

            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> EditEducation(int educationId)
    {
        var education = await _educationService.GetEducationByIdAsync(educationId);
        return View(education);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> EditEducation(EditEducationDTO model)
    {
        await _educationService.EditEducationAsync(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> DeleteEducation(int educationId)
    {
        var education = await _educationService.GetEducationByIdAsync(educationId);
        return View(education);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteEducation(EditEducationDTO model)
    {
        await _educationService.DeleteEducationAsync(model);
        return RedirectToAction(nameof(Index));
    }
}
