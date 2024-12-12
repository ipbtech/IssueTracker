using AutoMapper;
using IssueTracker.Entities;
using IssueTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.WebApp.Controllers
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
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
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
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
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
                        ModelState.AddModelError(string.Empty, "User with passed username is not found");
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
                            ModelState.AddModelError(string.Empty, "Entry is not allowed");
                            break;
                        case bool when result.RequiresTwoFactor:
                            ModelState.AddModelError(string.Empty, "2FA is not implemented");
                            break;
                        default:
                            ModelState.AddModelError(string.Empty, "Email or password is not valid");
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

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
