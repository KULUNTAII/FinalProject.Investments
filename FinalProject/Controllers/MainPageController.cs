using Microsoft.AspNetCore.Mvc;

namespace FinalProject.MVC.Controllers
{
    public class MainPageController : Controller
    {
        public ActionResult MainPage()
        {
            return View();
        }
    }
}
