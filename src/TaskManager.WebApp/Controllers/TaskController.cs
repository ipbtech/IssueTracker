using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IRepository<WorkTaskComment> _workTaskCommentsRepository;
        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;


        public TaskController(IWorkTaskRepository workTaskRepository, 
            IRepository<WorkTaskStatus> workTaskStatusesRepository, IRepository<WorkTaskComment> workTaskCommentsRepository,
            UserManager<User> userManager, ILogger<HomeController> logger, IMapper mapper)
        {
            _workTaskRepository = workTaskRepository;
            _workTaskStatusesRepository = workTaskStatusesRepository;
            _workTaskCommentsRepository = workTaskCommentsRepository;

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
                var task = await _workTaskRepository.GetFirstAsync(task => task.Id == id, task => task.Status, task => task.User) ??
                    throw new Exception($"Task with Id:{id} not found");

                var comments = await _workTaskCommentsRepository.GetAsync(com => com.TaskId == id, com => com.User);
                comments = comments.OrderByDescending(com => com.CreatedDateTimeUTC);
                ViewData["Comments"] = _mapper.Map<IEnumerable<WorkTaskCommentGetVM>>(comments);
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
            return PartialView("_CreateTask", viewModel);
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

                    var createdStatus = await _workTaskStatusesRepository.GetFirstAsync(task => task.Name == "Created") ??
                        throw new NullReferenceException("Created status is not found");

                    var task = _mapper.Map<WorkTask>(viewModel);
                    task.StatusId = createdStatus.Id;
                    task.UserId = currentUser.Id;

                    await _workTaskRepository.CreateAsync(task);
                    _logger.LogInformation("Task with Id:{@TaskId} was created", task.Id);
                    return Json(new { redirectUrl = Url.Action("Index", "Home") });
                }
                return PartialView("_CreateTask", viewModel);
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
                var task = await _workTaskRepository.GetFirstAsync(task => task.Id == id) ??
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
                var task = await _workTaskRepository.GetFirstAsync(task => task.Id == id) ??
                    throw new Exception($"Task with Id:{id} not found");

                var statuses = await _workTaskStatusesRepository.GetAllAsync();
                var viewModel = _mapper.Map<WorkTaskUpdateVM>(task);
                ViewData["Statuses"] = _mapper.Map<IEnumerable<WorkTaskStatusGetVM>>(statuses);
                return PartialView("_UpdateTask", viewModel);
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
                var statuses = await _workTaskStatusesRepository.GetAllAsync();
                ViewData["Statuses"] = _mapper.Map<IEnumerable<WorkTaskStatusGetVM>>(statuses);
                var doneStatus = statuses.FirstOrDefault(status => status.Name == "Done") ??
                    throw new NullReferenceException("Done status is not found");

                if (ModelState.IsValid)
                {
                    var task = await _workTaskRepository.GetFirstAsync(task => task.Id == viewModel.Id) ??
                        throw new NullReferenceException("Done status is not found");

                    _mapper.Map(viewModel, task);
                    if (doneStatus.Id == viewModel.StatusId)
                        task.ClosedDateTimeUTC = DateTime.UtcNow;

                    await _workTaskRepository.UpdateAsync(task);
                    _logger.LogInformation("Task with Id:{@TaskId} was updated", task.Id);
                    return Json(new { redirectUrl = Url.Action("Index", "Task", new { id = viewModel.Id }) });
                }
                return PartialView("_UpdateTask", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpGet]
        [Authorize]
        [Route("task/comment/{taskId}")]
        public IActionResult CreateComment(int taskId)
        {
            var viewModel = new WorkTaskCommentCreateVM();
            viewModel.TaskId = taskId;
            return PartialView("_CreateComment", viewModel);
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        [Route("task/comment")]
        public async Task<IActionResult> CreateComment(WorkTaskCommentCreateVM viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var currentUser = await _userManager.GetUserAsync(User);
                    if (currentUser is null)
                        return RedirectToAction("Login", "Account");

                    var comment = _mapper.Map<WorkTaskComment>(viewModel);
                    comment.UserId = currentUser.Id;

                    await _workTaskCommentsRepository.CreateAsync(comment);
                    _logger.LogInformation("Comment with Id:{@CommentId} was create for task with Id:{@TaskId}", comment.Id, comment.TaskId);
                    return Json(new { redirectUrl = Url.Action("Index", "Task", new { id = viewModel.TaskId }) });
                }
                return PartialView("_CreateComment", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }
    }
}
