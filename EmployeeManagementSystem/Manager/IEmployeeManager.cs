// -------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagementSystem.Common;

    /// <summary>
    /// interface for EmployeeManager
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void Add(Employee employee);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        void Delete(int Id);

        /// <summary>
        /// Gets all employee data.
        /// </summary>
        /// <returns>all employee data</returns>
        IEnumerable<Employee> GetAllEmployeeData();

        /// <summary>
        /// Gets the employee data by id.
        /// </summary>
        /// <param name="Empid">The employee id.</param>
        /// <returns>the data of employee</returns>
        Employee GetEmployeeDataById(int Empid);

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void Update(Employee employee);
    }
}
