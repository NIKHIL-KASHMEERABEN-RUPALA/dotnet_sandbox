using Microsoft.AspNetCore.Mvc;
namespace GrievanceManagementSystem.Controlllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}