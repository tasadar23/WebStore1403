﻿using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Services.Interfaces;
using WebStore.Models;
using WebStore.ViewModels;

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

        public IActionResult Create() => View("Edit", new EmployeeViewModel());

        public IActionResult Edit(int? Id)
        {
            if (Id is null)
                return View(new EmployeeViewModel());

            var employee = _EmployeesData.Get((int)Id);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel
            {
                Id = employee.Id,
                LastName = employee.LastName,
                Name = employee.FirstName,
                Patronymic = employee.Patronymic,
                Age = employee.Age
            });
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            var employee = new Employee
            {
                Id = model.Id,
                LastName = model.LastName,
                FirstName = model.Name,
                Patronymic = model.Patronymic,
                Age = model.Age
            };

            if (employee.Id == 0)
                _EmployeesData.Add(employee);
            else
            _EmployeesData.Update(employee);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            if (Id <= 0) return BadRequest();

            var employee = _EmployeesData.Get(Id);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel
            {
                Id = employee.Id,
                LastName = employee.LastName,
                Name = employee.FirstName,
                Patronymic = employee.Patronymic,
                Age = employee.Age
            });
        }

        [HttpPost]   //!!!Важно
        public IActionResult DeleteConfirmed(int id)
        {
            _EmployeesData.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
