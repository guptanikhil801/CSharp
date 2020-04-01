using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Manager;
using EmployeeManagementSystem.Common;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private IEmployeeManager employeemanager;

        public EmployeeController(IEmployeeManager employeemanager)
        {
            this.employeemanager = employeemanager;
        }
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
          return this.employeemanager.GetAllEmployeeData();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return this.employeemanager.GetEmployeeDataById(id);
        }

        // POST: api/Employee
        [HttpPost]
        public void Post(Employee employee)
        {
            this.employeemanager.Add(employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{employee}")]
        public void Put(Employee employee)
        {
            this.employeemanager.Update(employee);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.employeemanager.Delete(id);
        }
    }
}
