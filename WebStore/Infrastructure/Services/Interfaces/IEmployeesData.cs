using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Infrastructure.Services.Interfaces
{
    public interface IEmployeesData
    {
        //стандартные 5 операций chroot interface
        IEnumerable<Employee> Get();

        Employee Get(int id);

        int Add(Employee employee);

        void Update(Empoyees empoyee);

        bool Delete(int id);
    }
}
