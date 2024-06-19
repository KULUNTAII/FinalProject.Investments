using FinalProject.Application.Services.Interfaces;
using FinalProject.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.MVC.Controllers
{
    public class ProfileController(AppDbContext context, IAuthService authService) : Controller 
    {
        public ActionResult Profile()
        {
            return View();
        }

        public async Task<IActionResult> ShowMyProfile()
        {
            var currentUser = await authService.GetCurrentLoggedInUser();
            if (currentUser == null)
            {
                return NotFound();
            }
            await context.Entry(currentUser)
                  .Reference(u => u.Participant)
                  .LoadAsync();

            await context.Entry(currentUser.Participant)
                           .Collection(p => p.Projects)
                           .LoadAsync();
            return View("Profile", currentUser); // Передаем текущего пользователя в представление
        }
    }
}
