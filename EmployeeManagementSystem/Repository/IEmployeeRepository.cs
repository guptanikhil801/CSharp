// -------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagementSystem.Common;

    /// <summary>
    /// interface for EmployeeRepository
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>list of all employee</returns>
        IEnumerable<Employee> GetAllEmployee();

        /// <summary>
        /// Gets the employee by id.
        /// </summary>
        /// <param name="Empid">The empid.</param>
        /// <returns>employee details</returns>
        Employee GetEmployeeById(int Empid);

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void AddEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="Id">The id of employee.</param>
        void DeleteEmployee(int Id);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void UpdateEmployee(Employee employee);
    }
}