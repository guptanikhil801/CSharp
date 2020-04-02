// -------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// ------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagementSystem.Common;
    using EmployeeManagementSystem.Repository;

    /// <summary>
    /// manager class to return and call methods of Manager repository
    /// </summary>
    /// <seealso cref="EmployeeManagementSystem.Manager.IEmployeeManager" />
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// The instance variable 
        /// </summary>
        private readonly IEmployeeRepository emprepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="emprepo">The emprepo.</param>
        public EmployeeManager(IEmployeeRepository emprepo)
        {
            this.emprepo = emprepo;
        }

        /// <summary>
        /// Logins the specified Employee by using email and password
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        public bool Login(string email, string password)
        {
           return this.emprepo.EmployeeLogin(email, password);
        }

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Add(Employee employee)
        {
            this.emprepo.AddEmployee(employee);
        }

        /// <summary>
        /// Deletes the specified Employee by its id
        /// </summary>
        /// <param name="Id">The identifier.</param>
        public void Delete(int Id)
        {
            this.emprepo.DeleteEmployee(Id);
        }

        /// <summary>
        /// Gets all employee data.
        /// </summary>
        /// <returns>the employee details of all employee</returns>
        public IEnumerable<Employee> GetAllEmployeeData()
        {
            return this.emprepo.GetAllEmployee();
        }

        /// <summary>
        /// Gets the employee data by its id.
        /// </summary>
        /// <param name="Empid">The empid.</param>
        /// <returns>the employee details</returns>
        public Employee GetEmployeeDataById(int Empid)
        {
            return this.emprepo.GetEmployeeById(Empid);
        }

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Update(Employee employee)
        {
            this.emprepo.UpdateEmployee(employee);
        }
    }
}
