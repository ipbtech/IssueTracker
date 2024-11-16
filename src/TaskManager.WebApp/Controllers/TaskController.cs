using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManager.DAL.Contracts;

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
        public IActionResult Task(int id)
        {
            return View();
        }
    }
}
