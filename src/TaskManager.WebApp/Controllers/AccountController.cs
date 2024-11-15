using Microsoft.AspNetCore.Mvc;

namespace TaskManager.WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
