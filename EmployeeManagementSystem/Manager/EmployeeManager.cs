using EmployeeManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Repository;

namespace EmployeeManagementSystem.Manager
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository emprepo;
        public EmployeeManager(IEmployeeRepository emprepo)
        {
            this.emprepo = emprepo;
        }
        public void Add(Employee employee)
        {
            this.emprepo.AddEmployee(employee);
        }

        public void Delete(int Id)
        {
            this.emprepo.DeleteEmployee(Id);
        }

        public IEnumerable<Employee> GetAllEmployeeData()
        {
           return this.emprepo.GetAllEmployee();
        }

        public Employee GetEmployeeDataById(int Empid)
        {
            return this.emprepo.GetEmployeeById(Empid);
        }

        public void Update(Employee employee)
        {
            this.emprepo.UpdateEmployee(employee);
        }
    }
}
