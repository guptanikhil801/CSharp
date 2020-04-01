using EmployeeManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Manager
{
   public interface IEmployeeManager
    {
        void Add(Employee employee);
        void Delete(int Id);
        IEnumerable<Employee> GetAllEmployeeData();
        Employee GetEmployeeDataById(int Empid);
        void Update(Employee employee);
    }
}
