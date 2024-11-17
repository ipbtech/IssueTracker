using AutoMapper;
using Htmx;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.DAL.Contracts;
using TaskManager.Entities;
using TaskManager.ViewModels;

namespace TaskManager.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly IRepository<WorkTaskStatus> _statusesRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;

        private const int LOADING_COUNT = 8;

        public HomeController(UserManager<User> userManager, ILogger<HomeController> logger, IMapper mapper, 
            IWorkTaskRepository workTaskRepository, IRepository<WorkTaskStatus> statusesRepository)
        {
            _userManager = userManager;
            _workTaskRepository = workTaskRepository;
            _statusesRepository = statusesRepository;
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
                ViewData["NextPage"] = page + 1;
                var tasks = await _workTaskRepository.GetWorkTaskTableViewsAsync(LOADING_COUNT, page, sort);
                var viewModels = _mapper.Map<IEnumerable<WorkTaskTableGetVM>>(tasks);

                if (Request.IsHtmx())
                    return PartialView("_TableRows", viewModels);


                var allUsers = await _userManager.Users.ToListAsync();
                var allStatuses = await _statusesRepository.GetAllAsync();

                ViewData["AllStatuses"] = _mapper.Map<IEnumerable<WorkTaskStatusGetVM>>(allStatuses);
                ViewData["AllUsers"] = _mapper.Map<IEnumerable<UserGetVM>>(allUsers);
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
