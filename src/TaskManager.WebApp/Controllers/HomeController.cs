using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DAL.Contracts;
using TaskManager.Entities;
using TaskManager.ViewModels;

namespace TaskManager.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;

        private const int LOADING_COUNT = 15;

        public HomeController(UserManager<User> userManager, IWorkTaskRepository workTaskRepository, 
            ILogger<HomeController> logger, IMapper mapper)
        {
            _userManager = userManager;
            _workTaskRepository = workTaskRepository;
            _mapper = mapper;
            _logger = logger;
        }

        // sorting недавно созданные, давно созданные
        // filters по пользователю, по статусу

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index(int page, int sort, string[] user, string[] status)
        {
            try
            {
                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser is null)
                    return RedirectToAction("Login", "Account");

                page = page == 0 ? 1 : page;
                var tasks = await _workTaskRepository.GetWorkTaskTableViewsAsync(LOADING_COUNT, page, sort);
                var viewModels = _mapper.Map<IEnumerable<WorkTaskTableVM>>(tasks);

                ViewData["UserDisplayName"] = currentUser.DisplayName;
                return View(viewModels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }
    }
}
