﻿using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Data
{
    internal static class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = " Иванович", Age = 23 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Петр", Patronymic = " Петрович", Age = 31 },
            new Employee { Id = 3, LastName = "Сидоров", FirstName = "Сидор", Patronymic = " Сидорович", Age = 18 }

        };
    }
}
