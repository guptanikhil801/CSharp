// -------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeService.svc.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace EmployeeManagementWCF.Services
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// implementation class of IEmployeeService
    /// </summary>
    /// <seealso cref="EmployeeManagementWCF.Services.IEmployeeService" />
    public class EmployeeService : IEmployeeService
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        private Regex EmpIdval = new Regex("^[0-9]{1,3}$");
        private Regex FirstNameval = new Regex("^[A-Z]{1}[a-z]{1,29}$");
        private Regex LastNameval = new Regex("^[A-Z]{1}[a-z]{1,29}$");
        private Regex emailval = new Regex("^[A-Za-z]{1,30}[0-9]{0,20}@[A-Za-z]{1,10}.[A-Za-z]{1,10}$");
        private Regex passval = new Regex("^[A-Za-z0-9]{4,12}$");
        private Regex DepIdval = new Regex("^[0-9]{1}$");
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns>The response</returns>
        public string AddEmployee(Employee emp)
        {
            string result = string.Empty;
            if (FirstNameval.IsMatch(emp.FirstName) && LastNameval.IsMatch(emp.LastName) && emailval.IsMatch(emp.Email) && passval.IsMatch(emp.Password) && DepIdval.IsMatch(emp.DeptId.ToString()))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployeeWcf", this.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Password", emp.Password);
                cmd.Parameters.AddWithValue("@DeptId", emp.DeptId);
                this.con.Open();
                cmd.ExecuteNonQuery();
                this.con.Close();
                result = "Employee Data added Successsfully";
            }
            else
            {
                result = "Invalid data entered, please enter in correct form";
            }
            return result;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>the response</returns>
        public string DeleteEmployee(int id)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployeeWcf", this.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", id);
                this.con.Open();
                cmd.ExecuteNonQuery();
                this.con.Close();
                result = "Employee Record deleted successfully";
            }
            catch (Exception)
            {
                result = "Invalid Employee Id";
            }

            return result;
        }

        /// <summary>
        /// returns Employees details by id.
        /// </summary>
        /// <param name="id">The Employee id.</param>
        /// <returns> Employee Details By Id</returns>
        public DataSet EmployeeDetailsById(int id)
        {
            DataSet dset = new DataSet();
            SqlCommand cmd = new SqlCommand("spGetEmployeeByIdWcf", this.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", id);
            this.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dset);
            cmd.ExecuteNonQuery();
            this.con.Close();
            return dset;
        }

        /// <summary>
        /// Gets the employee details of all employee.
        /// </summary>
        /// <returns>the employee details</returns>
        public DataSet GetEmployeeDetails()
        {
            DataSet dset = new DataSet();
            SqlCommand cmd = new SqlCommand("spGetEmployeeWcf", this.con);
            cmd.CommandType = CommandType.StoredProcedure;
            this.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dset);
            cmd.ExecuteNonQuery();
            this.con.Close();
            return dset;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="emp">The employee.</param>
        /// <returns>the response</returns>
        public string UpdateEmployee(Employee emp)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployeeWcf", this.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Password", emp.Password);
                cmd.Parameters.AddWithValue("@DeptId", emp.DeptId);
                this.con.Open();
                cmd.ExecuteNonQuery();
                this.con.Close();
                result = "Employee Data updated successfully";
            }
            catch (Exception)
            {
                result = "Invalid data entered";
            }

            return result;
        }
    }
}