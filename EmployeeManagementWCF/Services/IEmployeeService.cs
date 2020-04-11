// -------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeService.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace EmployeeManagementWCF.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    /// <summary>
    /// Interface for EmployeeService
    /// </summary>
    [ServiceContract]
    public interface IEmployeeService
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns>the response</returns>
        [OperationContract]
        string AddEmployee(Employee emp);

        /// <summary>
        /// Gets the employee details.
        /// </summary>
        /// <returns>employee list</returns>
        [OperationContract]
        DataSet GetEmployeeDetails();

        /// <summary>
        /// Employees details by id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>the employee details</returns>
        [OperationContract]
        DataSet EmployeeDetailsById(int id);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>the response</returns>
        [OperationContract]
        string DeleteEmployee(int id);

        /// <summary>
        /// Updates the employee details.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns>The response</returns>
        [OperationContract]
        string UpdateEmployee(Employee emp);
    }

    /// <summary>
    /// To define Employee
    /// </summary>
    [DataContract]
    public class Employee
    {
        /// <summary>
        /// Gets or sets the emp id.
        /// </summary>
        /// <value>
        /// The emp identifier.
        /// </value>
        [DataMember]
        public int EmpId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the dept identifier.
        /// </summary>
        /// <value>
        /// The dept identifier.
        /// </value>
        [DataMember]
        public int DeptId { get; set; }
    }
}