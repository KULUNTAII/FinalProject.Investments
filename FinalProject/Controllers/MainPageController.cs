using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.MVC.Controllers
{
    public class MainPageController(IProjectService projectService) : Controller
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
    }
}
