using FinalProject.Application.Contracts;
using FinalProject.Application.Services;
using FinalProject.Application.Services.Interfaces;
using FinalProject.Domain.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.MVC.Controllers
{
    public class ProjectController(IProjectService projectService, IAuthService authService, AppDbContext context) : Controller
    {
        public ActionResult Project()
        {
            return View();
        }

        [Authorize]   
        public async Task<IActionResult> ProjectForm(ProjectCreateDto dto)
        {
            dto.CreationDate = DateTime.Now;
            await projectService.CreateAsync(dto);
            return RedirectToAction("MainPage", "MainPage");
        }

        public async Task<IActionResult> ShowProjects()
        {
            var projects = await projectService.GetAllAsync();
            return View(projects);
        }
    }
}
