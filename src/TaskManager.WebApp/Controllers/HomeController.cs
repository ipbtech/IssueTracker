using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Entities;

namespace TaskManager.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(UserManager<User> userManager, ILogger<HomeController> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }


        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user is null)
                return RedirectToAction("Login", "Account");

            ViewData["UserDisplayName"] = user.DisplayName;


            return View();
        }
    }
}
