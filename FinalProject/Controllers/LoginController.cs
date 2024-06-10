using FinalProject.Services;
using FinalProject.Controllers;
using FinalProject.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using SpotiPie.Application.Contracts;
using FinalProject.Application.Services.Interfaces;

namespace FinalProject.MVC.Controllers
{
    public class LoginController(IAuthService authService) : Controller
    {
        [HttpGet]
        public ActionResult Login(string login, string password)
        {
            return View();
        }

        public async Task<IActionResult> LoginUser(string login, string password)
        {
            await authService.LoginWithHttpContext(login, password);
            return RedirectToAction("MainPage", "MainPage");
        }
    }
}
