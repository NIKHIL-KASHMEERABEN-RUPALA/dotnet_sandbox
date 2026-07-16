using Microsoft.AspNetCore.Mvc;
using GrievanceManagementSystem.Services;
using GrievanceManagementSystem.ViewModels;

namespace GrievanceManagementSystem.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            return View(
                _roleService.GetAllRoles()
            );
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RoleViewModel role)
        {
            if (!ModelState.IsValid)
                return View(role);

            _roleService.AddRole(role);

            TempData["Success"] =
                "Role created successfully.";

            return RedirectToAction(nameof(Index));
        }
    }
}