using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DAL.Contracts;
using TaskManager.ViewModels;

namespace TaskManager.WebApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;


        public TaskController(IWorkTaskRepository workTaskRepository, ILogger<HomeController> logger, IMapper mapper)
        {
            _workTaskRepository = workTaskRepository;
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
                var viewModel = _mapper.Map<WorkTaskVM>(task);
                return View(viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }
    }
}
