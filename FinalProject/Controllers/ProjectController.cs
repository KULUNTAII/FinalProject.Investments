using AutoMapper;
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
        public async Task<IActionResult> ProjectForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProjectForm(ProjectCreateDto dto)
        {
            if (dto.file != null && dto.file.Length > 0)
            {
                dto.CreationDate = DateTime.Now;
                var fileName = Path.GetFileNameWithoutExtension(dto.file.FileName) + dto.Name + Path.GetExtension(dto.file.FileName);
                var filePath = Path.Combine("wwwroot", "uploads", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await dto.file.CopyToAsync(stream);
                }
                dto.filePath = fileName;
                await projectService.CreateAsync(dto);
            }
            else
            {
                ViewBag.Message = "Please choose a valid file";
            }

            return RedirectToAction("MainPage", "MainPage");
        }

        public async Task<IActionResult> ShowProjects()
        {
            var projects = await projectService.GetAllAsync();
            return View(projects);
        }
    }
}
