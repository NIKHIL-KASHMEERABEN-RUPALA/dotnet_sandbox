using GrievanceManagementSystem.Services;
using GrievanceManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GrievanceManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly ILogger<DepartmentController> _logger;

        // Injecting both the Department Service and the Logger
        public DepartmentController(
            IDepartmentService departmentService,
            ILogger<DepartmentController> logger)
        {
            _departmentService = departmentService;
            _logger = logger;
        }

        // GET: /Department/Index
        public IActionResult Index()
        {
            // Log fetching departments
            _logger.LogInformation("Fetching Departments");

            return View(_departmentService.GetAllDepartments());
        }

        // GET: /Department/Create
        public IActionResult Create()
        {
            _logger.LogInformation("Navigated to Department Creation page.");
            return View();
        }

        // POST: /Department/Create
        [HttpPost]
        public IActionResult Create(DepartmentViewModel department)
        {
            if (!ModelState.IsValid)
                return View(department);

            _departmentService.AddDepartment(department);

            // Log that the department was successfully created
            // Assumes DepartmentViewModel has a property named DepartmentName or Name
            _logger.LogInformation("Department Created : {DepartmentName}", department.DepartmentName);

            TempData["Success"] = "Department created successfully.";

            return RedirectToAction(nameof(Index));
        }
    }
}