// -------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// ------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagementSystem.Manager;
    using EmployeeManagementSystem.Common;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// controller of api
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The employee manager variable
        /// </summary>
        private IEmployeeManager employeemanager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="employeemanager">The employee manager.</param>
        public EmployeeController(IEmployeeManager employeemanager)
        {
            this.employeemanager = employeemanager;
        }

        /// <summary>
        /// method to get all employee list
        /// </summary>
        /// <returns>all employee</returns>
        //// GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return this.employeemanager.GetAllEmployeeData();
        }

        /// <summary>
        /// to get employee details by Employee id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> the employee</returns>
        //// GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return this.employeemanager.GetEmployeeDataById(id);
        }

        /// <summary>
        /// to Add a new employee
        /// </summary>
        /// <param name="employee">employee details</param>
        //// POST: api/Employee
        [HttpPost]
        public void Post(Employee employee)
        {
            this.employeemanager.Add(employee);
        }

        /// <summary>
        /// to update a employee details
        /// </summary>
        /// <param name="employee">employee details</param>
        //// PUT: api/Employee/5
        [HttpPut("{employee}")]
        public void Put(Employee employee)
        {
            this.employeemanager.Update(employee);
        }

        /// <summary>
        /// to delete a employee from list
        /// </summary>
        /// <param name="id"></param>
        //// DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.employeemanager.Delete(id);
        }
    }
}