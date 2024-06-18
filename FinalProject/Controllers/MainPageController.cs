using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.MVC.Controllers
{
    public class MainPageController(IProjectService projectService, AppDbContext context) : Controller
    {
        public ActionResult MainPage()
        {
            return View();
        }

        public async Task<IActionResult> ShowProjects()
        {
            var projects = await projectService.GetAllAsync();

            return PartialView("_ProjectsPartial", projects);
        }

        public async Task<IActionResult> ShowProjectsDetails(int projectId)
        {
            var project = await context.Projects
        .Include(p => p.Participants)
        .Include(p => p.Investors)
        .FirstOrDefaultAsync(p => p.Id == projectId);
            return View(project);
        }
    }
}
