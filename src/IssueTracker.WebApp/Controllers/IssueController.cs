using AutoMapper;
using IssueTracker.DAL.Contracts;
using IssueTracker.Entities;
using IssueTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.WebApp.Controllers
{
    public class IssueController : Controller
    {
        private readonly IIssueRepository _issueRepository;
        private readonly IRepository<Status> _statusRepository;
        private readonly IRepository<Comment> _commentRepository;
        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;


        public IssueController(IIssueRepository issueRepository, 
            IRepository<Status> statusRepository, IRepository<Comment> commentRepository,
            UserManager<User> userManager, ILogger<HomeController> logger, IMapper mapper)
        {
            _issueRepository = issueRepository;
            _statusRepository = statusRepository;
            _commentRepository = commentRepository;

            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet]
        [Authorize]
        [Route("issue/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            try
            {
                var issue = await _issueRepository.GetFirstAsync(issue => issue.Id == id, 
                    issue => issue.Status, issue => issue.User) ??
                    throw new Exception($"Issue with Id:{id} not found");

                var comments = await _commentRepository.GetAsync(com => com.IssueId == id, com => com.User);
                comments = comments.OrderByDescending(com => com.CreatedDateTimeUTC);
                ViewData["Comments"] = _mapper.Map<IEnumerable<CommentGetVM>>(comments);
                var viewModel = _mapper.Map<IssueGetVM>(issue);
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
        [Route("issue/create")]
        public IActionResult Create()
        {
            var viewModel = new IssueCreateVM();
            return PartialView("_CreateIssue", viewModel);
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IssueCreateVM viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var currentUser = await _userManager.GetUserAsync(User);
                    if (currentUser is null)
                        return RedirectToAction("Login", "Account");

                    var createdStatus = await _statusRepository.GetFirstAsync(task => task.Name == "Created") ??
                        throw new NullReferenceException("Created status is not found");

                    var issue = _mapper.Map<Issue>(viewModel);
                    issue.StatusId = createdStatus.Id;
                    issue.UserId = currentUser.Id;

                    await _issueRepository.CreateAsync(issue);
                    _logger.LogInformation("Issue with Id:{@IssueId} was created", issue.Id);
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
                var issue = await _issueRepository.GetFirstAsync(issue => issue.Id == id) ??
                    throw new Exception($"Issue with Id:{id} not found");

                await _issueRepository.DeleteAsync(issue);
                _logger.LogInformation("Issue with Id:{@IssueId} was deleted", id);
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
                var issue = await _issueRepository.GetFirstAsync(issue => issue.Id == id) ??
                    throw new Exception($"Issue with Id:{id} not found");

                var statuses = await _statusRepository.GetAllAsync();
                var viewModel = _mapper.Map<IssueUpdateVM>(issue);
                ViewData["Statuses"] = _mapper.Map<IEnumerable<StatusGetVM>>(statuses);
                return PartialView("_UpdateIssue", viewModel);
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
        public async Task<IActionResult> Update(IssueUpdateVM viewModel)
        {
            try
            {
                var statuses = await _statusRepository.GetAllAsync();
                ViewData["Statuses"] = _mapper.Map<IEnumerable<StatusGetVM>>(statuses);
                var doneStatus = statuses.FirstOrDefault(status => status.Name == "Done") ??
                    throw new NullReferenceException("Done status is not found");

                if (ModelState.IsValid)
                {
                    var issue = await _issueRepository.GetFirstAsync(issue => issue.Id == viewModel.Id) ??
                        throw new NullReferenceException("Done status is not found");

                    _mapper.Map(viewModel, issue);
                    if (doneStatus.Id == viewModel.StatusId)
                        issue.ClosedDateTimeUTC = DateTime.UtcNow;

                    await _issueRepository.UpdateAsync(issue);
                    _logger.LogInformation("Issue with Id:{@IssueId} was updated", issue.Id);
                    return Json(new { redirectUrl = Url.Action("Index", "Issue", new { id = viewModel.Id }) });
                }
                return PartialView("_UpdateIssue", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpGet]
        [Authorize]
        [Route("issue/comment/{issueId}")]
        public IActionResult CreateComment(int issueId)
        {
            var viewModel = new CommentCreateVM();
            viewModel.IssueId = issueId;
            return PartialView("_CreateComment", viewModel);
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        [Route("issue/comment")]
        public async Task<IActionResult> CreateComment(CommentCreateVM viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var currentUser = await _userManager.GetUserAsync(User);
                    if (currentUser is null)
                        return RedirectToAction("Login", "Account");

                    var comment = _mapper.Map<Comment>(viewModel);
                    comment.UserId = currentUser.Id;

                    await _commentRepository.CreateAsync(comment);
                    _logger.LogInformation("Comment with Id:{@CommentId} was create for issue with Id:{@IssueId}", comment.Id, comment.IssueId);
                    return Json(new { redirectUrl = Url.Action("Index", "Issue", new { id = viewModel.IssueId }) });
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
