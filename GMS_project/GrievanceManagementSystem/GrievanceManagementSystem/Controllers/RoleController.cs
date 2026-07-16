using GrievanceManagementSystem.Services;
using GrievanceManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace GrievanceManagementSystem.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        private readonly ILogger<RoleController> _logger;

        public RoleController(IRoleService roleService, ILogger<RoleController> logger)
        {
            _roleService = roleService;
            _logger = logger;
        }

        // GET: /Role/Index
        public IActionResult Index()
        {
            _logger.LogInformation("Fetching all roles.");
            return View(_roleService.GetAllRoles());
        }

        // GET: /Role/Create (Renders the empty form page)
        public IActionResult Create()
        {
            _logger.LogInformation("Navigated to Role Creation page."); // Optional: Log just the navigation instead
            return View();
        }

        // POST: /Role/Create (Handles the actual form submission)
        [HttpPost]
        public IActionResult Create(RoleViewModel role)
        {
            if (!ModelState.IsValid)
                return View(role);

            _roleService.AddRole(role);

            //  Moved here where 'role' actually exists and is saved!
            _logger.LogInformation("New role created : {RoleName}", role.RoleName);

            TempData["Success"] = "Role created successfully.";

            return RedirectToAction(nameof(Index));
        }
    }
}