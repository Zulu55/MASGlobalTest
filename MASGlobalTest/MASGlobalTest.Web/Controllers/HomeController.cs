namespace MASGlobalTest.Web.Controllers
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using Data;
    using MASGlobalTest.Common.Models;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
            this.employeeRepository.GetDataAsync().Wait();
        }

        public IActionResult Index()
        {
            return View(new EmployeeViewModel { });
        }

        [HttpPost]
        public IActionResult Index(EmployeeViewModel model)
        {
            if (model.EmployeeId == null)
            {
                model.Employees = this.employeeRepository.GetEmployees();
                return View(model);
            }

            var employee = this.employeeRepository.GetEmployeeById(model.EmployeeId.Value);
            if (employee == null)
            {
                ViewBag.Message = "Employe not found.";
                return View(model);
            }

            model.Employees = new List<Employee>();
            model.Employees.Add(employee);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
