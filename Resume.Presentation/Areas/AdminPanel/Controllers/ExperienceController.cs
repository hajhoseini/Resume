using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.AdminSide.Experience;
using Resume.Application.Services.Interfaces;

namespace Resume.Presentation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class ExperienceController : Controller
{
    private readonly IExperienceService _experienceService;

    public ExperienceController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var model = _experienceService.GetListOFExperiences();
        return View(model);
    }    

    [HttpGet]
    public IActionResult CreateExperience()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateExperience(CreateExperienceDTO model)
    {
        if (ModelState.IsValid)
        {
            await _experienceService.AddExperienceAsync(model);
            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> EditExperience(int experienceId)
    {
        var Experience = await _experienceService.GetExperienceByIdAsync(experienceId);
        return View(Experience);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> EditExperience(EditExperienceDTO model)
    {
        await _experienceService.EditExperienceAsync(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> DeleteExperience(int experienceId)
    {
        var Experience = await _experienceService.GetExperienceByIdAsync(experienceId);
        return View(Experience);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteExperience(EditExperienceDTO model)
    {
        await _experienceService.DeleteExperienceAsync(model);
        return RedirectToAction(nameof(Index));
    }
}
