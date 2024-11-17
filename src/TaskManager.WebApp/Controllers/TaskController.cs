using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DAL.Contracts;
using TaskManager.Entities;
using TaskManager.ViewModels;

namespace TaskManager.WebApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly IRepository<WorkTaskStatus> _workTaskStatusesRepository;
        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;


        public TaskController(IWorkTaskRepository workTaskRepository, IRepository<WorkTaskStatus> workTaskStatusesRepository,
            UserManager<User> userManager, ILogger<HomeController> logger, IMapper mapper)
        {
            _workTaskRepository = workTaskRepository;
            _workTaskStatusesRepository = workTaskStatusesRepository;
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            try
            {
                var task = await _workTaskRepository.GetFirstAsync(task => task.Id == id,
                    task => task.Status, task => task.User);
                var viewModel = _mapper.Map<WorkTaskGetVM>(task);
                return View(viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new WorkTaskCreateVM();
            return PartialView("_Create", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WorkTaskCreateVM viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var currentUser = await _userManager.GetUserAsync(User);
                    if (currentUser is null)
                        return RedirectToAction("Login", "Account");

                    var createdStatus = await _workTaskStatusesRepository.GetFirstAsync(task => task.Name == "Created");
                    var task = _mapper.Map<WorkTask>(viewModel);
                    task.StatusId = createdStatus.Id;
                    task.UserId = currentUser.Id;

                    await _workTaskRepository.CreateAsync(task);
                    TempData["CreatedTaskNotification"] = " • Task was created successful. One more time?";
                    _logger.LogInformation("Task with Id:{@TaskId} was created", task.Id);
                    return RedirectToAction("Create");
                }
                return PartialView("_Create", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }
    }
}
