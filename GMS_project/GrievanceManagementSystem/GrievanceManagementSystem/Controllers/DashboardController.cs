using Microsoft.AspNetCore.Mvc;

namespace GrievanceManagementSystem.Controllers
{
    /// <summary>
    /// Controller responsible for displaying the application's dashboard.
    /// </summary>
    public class DashboardController : Controller
    {
        /// <summary>
        /// Displays dashboard page.
        /// </summary>
        /// <returns>Dashboard View</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}