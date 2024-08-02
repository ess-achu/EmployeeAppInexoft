using EmployeeApp.Models;
using EmployeeApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("AdminPanel");
        }
        public IActionResult AdminPanel()
        {
            EmployeeServices employeeServices = new EmployeeServices();
            var app = employeeServices.GetEmployees();
            return View(app);
        }

        public IActionResult EmployeeDetails(int id)
        {
            EmployeeServices employeeServices = new EmployeeServices();
            var app = employeeServices.GetEmployeeAndSalary(id);
            if (app == null)
            {
                return RedirectToAction("AdminPanel");
            }
            return View(app);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
