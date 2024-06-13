using FinalProject.Services;
using FinalProject.Application.Contracts;
using FinalProject.Application.Services.Interfaces;
using FinalProject.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Controllers;

namespace FinalProject.MVC.Controllers
{
    public class RegisterController(IUserService userService) : Controller
    {
        public ActionResult Register()
        {
            ViewBag.Roles = new List<string> { "Participant", "Investor", "Guest" };
            ViewBag.InvestorTypes = new List<string> { "Private", "Corporative", "Institutional" };
            return View();
        }

        public async Task<IActionResult> RegisterForm(UserCreateDto dto)
        {
            if (ViewBag.Roles == "Investor") 
            {
                dto.Participant = null;
            }
            if (ViewBag.Roles == "Participant")
            {
                dto.Investor = null;
            }
            await userService.CreateUserAsync(dto);
            return RedirectToAction("MainPage", "MainPage");
        }

        public ActionResult FinalRegisterForm(UserCreateDto dto)
        {
            //TODO сохранить данные через UserService
            return RedirectToAction("Index", "Home");
        }
    }
}
