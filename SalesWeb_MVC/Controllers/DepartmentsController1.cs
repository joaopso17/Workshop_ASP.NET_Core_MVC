using Microsoft.AspNetCore.Mvc;
using SalesWeb_MVC.Models;
using SalesWeb_MVC.Models.ViewModels;
using System.Diagnostics;

namespace SalesWeb_MVC.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly ILogger<DepartmentsController> _logger;

        public DepartmentsController(ILogger<DepartmentsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });

            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
