using Microsoft.AspNetCore.Mvc;
using GrievanceManagementSystem.Services;
using GrievanceManagementSystem.ViewModels;

namespace GrievanceManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(
            IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var departments =
                _departmentService.GetAllDepartments();

            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(
            DepartmentViewModel department)
        {
            if (!ModelState.IsValid)
            {
                return View(department);
            }

            _departmentService.AddDepartment(department);

            TempData["Success"] =
                "Department Created Successfully";

            return RedirectToAction(nameof(Index));
        }
    }
}