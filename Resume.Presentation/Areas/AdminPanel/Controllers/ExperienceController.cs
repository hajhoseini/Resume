using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.AdminSide.Experience;
using Resume.Application.Services.Interfaces;

namespace Resume.Presentation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class ExperienceController : Controller
{
    private readonly IExperienceService _ExperienceService;

    public ExperienceController(IExperienceService ExperienceService)
    {
        _ExperienceService = ExperienceService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var model = _ExperienceService.GetListOFExperiences();
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
            await _ExperienceService.AddExperienceAsync(model);
            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> EditExperience(int ExperienceId)
    {
        var Experience = await _ExperienceService.GetExperienceByIdAsync(ExperienceId);
        return View(Experience);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> EditExperience(EditExperienceDTO model)
    {
        await _ExperienceService.EditExperienceAsync(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> DeleteExperience(int ExperienceId)
    {
        var Experience = await _ExperienceService.GetExperienceByIdAsync(ExperienceId);
        return View(Experience);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteExperience(EditExperienceDTO model)
    {
        await _ExperienceService.DeleteExperienceAsync(model);
        return RedirectToAction(nameof(Index));
    }
}
