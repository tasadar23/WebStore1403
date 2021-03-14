using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    //[NonController]
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    //return Content("Firest Controller Action");
        //    return View();
        //}

        public static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LasttName = "Иванов", FirstName = "Иван", Patronymic = " Иванович", Age = 23 },
            new Employee { Id = 1, LasttName = "Петров", FirstName = "Петр", Patronymic = " Петрович", Age = 31 },
            new Employee { Id = 1, LasttName = "Сидоров", FirstName = "Сидр", Patronymic = " Сидорович", Age = 18 }

        };
        public IActionResult Index() => View();

        public IActionResult SecondAction(string id) => Content($"Action with value id:{id}");

        public IActionResult Employees()
        {
            return View(_Employees);
        }
    }
}
