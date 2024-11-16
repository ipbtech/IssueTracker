using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Entities;
using TaskManager.ViewModels;

namespace TaskManager.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        

        public AccountController(
            UserManager<User> userManager, SignInManager<User> signInManager, 
            ILogger<AccountController> logger, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
        }



        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = _mapper.Map<User>(viewModel);
                    var result = await _userManager.CreateAsync(user, viewModel.Password);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User with Id:{@UserId} is created", user.Id);
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home");
                    }
                    var errors = result.Errors.Select(err => $"{err.Code}:{err.Description}").ToList();
                    errors.ForEach(err => ModelState.AddModelError(string.Empty, err));
                }
                return View(viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.FindByNameAsync(viewModel.Login);
                    if (user is null)
                    {
                        ModelState.AddModelError(string.Empty, "User with passed login is not found");
                        return View(viewModel);
                    }

                    var result = await _signInManager.PasswordSignInAsync(user, viewModel.Password, viewModel.RememberMe, false);
                    switch (true)
                    {
                        case bool when result.Succeeded:
                            _logger.LogInformation("The user with Id:{@UserId} is logged in", user.Id);
                            return RedirectToAction("Index", "Home");
                        case bool when result.IsLockedOut:
                            ModelState.AddModelError(string.Empty, "User is locked. Try later or confirm your email");
                            break;
                        case bool when result.IsNotAllowed:
                            ModelState.AddModelError(string.Empty, "Email or password is not valid");
                            break;
                        case bool when result.RequiresTwoFactor:
                            ModelState.AddModelError(string.Empty, "2FA is not implemented");
                            break;
                        default:
                            ModelState.AddModelError(string.Empty, "Something wrong");
                            break;
                    }   
                }
                return View(viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
