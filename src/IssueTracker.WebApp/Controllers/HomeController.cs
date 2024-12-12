using AutoMapper;
using Htmx;
using IssueTracker.DAL.Contracts;
using IssueTracker.Entities;
using IssueTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IIssueRepository _issueRepository;
        private readonly IRepository<Status> _statusRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;

        private const int LOADING_COUNT = 8;

        public HomeController(UserManager<User> userManager, ILogger<HomeController> logger, IMapper mapper,
            IIssueRepository issueRepository, IRepository<Status> statusRepository)
        {
            _userManager = userManager;
            _issueRepository = issueRepository;
            _statusRepository = statusRepository;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index(int? page, int? sort, int? user, int? status)
        {
            try
            {
                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser is null)
                    return RedirectToAction("Login", "Account");

                int pageReq = page is null || page == 0 ? 1 : (int)page;
                int sortReq = sort is null ? 0 : (int)sort;
                ViewData["NextPage"] = pageReq + 1;

                var issues = await _issueRepository.GetWorkTaskTableViewsAsync(LOADING_COUNT, pageReq, sortReq, user, status);
                var viewModels = _mapper.Map<IEnumerable<IssueTableRowVM>>(issues);
                if (Request.IsHtmx())
                    return PartialView("_TableRows", viewModels);


                var allUsers = await _userManager.Users.ToListAsync();
                var allStatuses = await _statusRepository.GetAllAsync();

                ViewData["Statuses"] = _mapper.Map<IEnumerable<StatusGetVM>>(allStatuses);
                ViewData["Users"] = _mapper.Map<IEnumerable<UserGetVM>>(allUsers);
                ViewData["CurrentUserName"] = currentUser.DisplayName;
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
