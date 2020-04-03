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
        public IActionResult Get()
        {
            var allemployee = this.employeemanager.GetAllEmployeeData();
            return this.Ok(allemployee);
        }

        /// <summary>
        /// to get employee details by Employee id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> the employee</returns>
        //// GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var detailsbyid = this.employeemanager.GetEmployeeDataById(id);
            return this.Ok(detailsbyid);
        }

        /// <summary>
        /// to Add a new employee
        /// </summary>
        /// <param name="employee">employee details</param>
        //// POST: api/Employee
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
             this.employeemanager.Add(employee);
            return this.Ok();
        }

        /// <summary>
        /// to update a employee details
        /// </summary>
        /// <param name="employee">employee details</param>
        //// PUT: api/Employee/5
        [HttpPut("{employee}")]
        public IActionResult Put(Employee employee)
        {
            this.employeemanager.Update(employee);
            return this.Ok();
        }

        /// <summary>
        /// to delete a employee from list
        /// </summary>
        /// <param name="id"></param>
        //// DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.employeemanager.Delete(id);
            return this.Ok();
        }
    }
}