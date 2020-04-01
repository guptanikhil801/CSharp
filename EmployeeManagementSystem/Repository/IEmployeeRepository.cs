namespace EmployeeManagementSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagementSystem.Common;
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById(int Empid);
        void AddEmployee(Employee employee);
        void DeleteEmployee(int Id);
        void UpdateEmployee(Employee employee);
    }
}