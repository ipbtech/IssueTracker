using Microsoft.AspNetCore.Mvc;

namespace TaskManager.WebApp.Controllers
{
    public class AccountController : Controller
    {
        
        
        
        
        
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        
        
        public IActionResult Login()
        {
            return View();
        }
    }
}
