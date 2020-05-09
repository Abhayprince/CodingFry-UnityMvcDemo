using System.Web.Mvc;
using UnityMvcDemoCodingFry.Models;

namespace UnityMvcDemoCodingFry.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult GetAll()
        {
            var employeeList = _employeeService.GetEmployees();
            return View(employeeList);
        }

        public ActionResult GetEmployee(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }

        public ActionResult Add()
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult Add(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.AddEmployee(model);
                return RedirectToAction("GetAll");
            }
            return View(model);
        }
    }
}