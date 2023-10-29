using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.AdminSide.MySkills;
using Resume.Application.Services.Interfaces;

namespace Resume.Presentation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class MySkillsController : Controller
{
    private readonly IMySkillsService _mySkillsService;

    public MySkillsController(IMySkillsService mySkillsService)
    {
        _mySkillsService = mySkillsService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var model = _mySkillsService.GetListOFMySkills();
        return View(model);
    }    

    [HttpGet]
    public IActionResult CreateMySkills()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateMySkills(CreateMySkillsDTO model)
    {
        if (ModelState.IsValid)
        {
            await _mySkillsService.AddMySkillsAsync(model);
            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> EditMySkills(int mySkillsId)
    {
        var MySkills = await _mySkillsService.GetMySkillsByIdAsync(mySkillsId);
        return View(MySkills);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> EditMySkills(EditMySkillsDTO model)
    {
        await _mySkillsService.EditMySkillsAsync(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> DeleteMySkills(int mySkillsId)
    {
        var MySkills = await _mySkillsService.GetMySkillsByIdAsync(mySkillsId);
        return View(MySkills);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteMySkills(EditMySkillsDTO model)
    {
        await _mySkillsService.DeleteMySkillsAsync(model);
        return RedirectToAction(nameof(Index));
    }
}
