using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
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
        [Authorize]
        [Route("task/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            try
            {
                var task = await _workTaskRepository.GetFirstAsync(task => task.Id == id, 
                    task => task.Status, task => task.User);
                if (task is null)
                    throw new Exception($"Task with Id:{id} not found");

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
        [Authorize]
        [Route("task/create")]
        public IActionResult Create()
        {
            var viewModel = new WorkTaskCreateVM();
            return PartialView("_Create", viewModel);
        }


        [HttpPost]
        [Authorize]
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
                    _logger.LogInformation("Task with Id:{@TaskId} was created", task.Id);
                    //TempData["CreatedTaskNotification"] = " • Task was created successful. One more time?";
                    //return RedirectToAction("Create");
                    return RedirectToAction("Index", "Home");
                }
                return PartialView("_Create", viewModel); //TODO
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var task = await _workTaskRepository.GetFirstAsync(task => task.Id == id);
                if (task is null)
                    throw new Exception($"Task with Id:{id} not found");

                await _workTaskRepository.DeleteAsync(task);
                _logger.LogInformation("Task with Id:{@TaskId} was deleted", id);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Update(int id)
        {
            try
            {
                var task = await _workTaskRepository.GetFirstAsync(task => task.Id == id);
                if (task is null)
                    throw new Exception($"Task with Id:{id} not found");

                var statuses = await _workTaskStatusesRepository.GetAllAsync();
                var viewModel = _mapper.Map<WorkTaskUpdateVM>(task);
                ViewData["Statuses"] = _mapper.Map<IEnumerable<WorkTaskStatusGetVM>>(statuses);
                return PartialView("_Update", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(WorkTaskUpdateVM viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var task = await _workTaskRepository.GetFirstAsync(task => task.Id == viewModel.Id);
                    _mapper.Map(viewModel, task);

                    await _workTaskRepository.UpdateAsync(task);
                    _logger.LogInformation("Task with Id:{@TaskId} was updated", task.Id);
                    return RedirectToAction("Index", "Task", new { id = viewModel.Id });
                }
                //var statuses = await _workTaskStatusesRepository.GetAllAsync();
                //ViewData["Statuses"] = _mapper.Map<IEnumerable<WorkTaskStatusGetVM>>(statuses);
                return PartialView("_Update", viewModel); //TODO
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }
    }
}
