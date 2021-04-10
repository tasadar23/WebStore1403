using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data;
using WebStore.Infrastructure.Services.Interfaces;
using WebStore.Models;

namespace WebStore.Controllers
{
    //[Route("Stuff")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;
        //private readonly List<Employee> _Employees;
        
        public EmployeesController(IEmployeesData EmployeesData)
        {
            _EmployeesData = EmployeesData;
            //_Employees = TestData.Employees;
            
        }

        //[Route("all")]
        public IActionResult Index() => View(_EmployeesData.Get());

        //[Route("info-(id-{id})")]
        public IActionResult Details(int Id)
        {
            //var employee = _Employees.FirstOrDefault(e => e.Id == Id);
            var employee = _EmployeesData.Get(Id);
            if (employee is null)
                return NotFound();

            return View(employee);
        }
    }
}
