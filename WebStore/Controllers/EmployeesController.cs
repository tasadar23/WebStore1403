using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        public static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LasttName = "Иванов", FirstName = "Иван", Patronymic = " Иванович", Age = 23 },
            new Employee { Id = 2, LasttName = "Петров", FirstName = "Петр", Patronymic = " Петрович", Age = 31 },
            new Employee { Id = 3, LasttName = "Сидоров", FirstName = "Сидор", Patronymic = " Сидорович", Age = 18 }

        };
        public IActionResult Index() => View(_Employees);
    }
}
