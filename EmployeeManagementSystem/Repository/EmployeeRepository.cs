// -------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagementSystem.Common;
    using EmployeeManagementSystem.Utility;
    
    /// <summary>
    /// implementation class of IEmployeeRepository
    /// </summary>
    /// <seealso cref="EmployeeManagementSystem.Repository.IEmployeeRepository" />
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// The connection to database
        /// </summary>
        private string connectionString = ConnectionString.CName;

        /// <summary>
        /// it Adds the employee to database.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empid", employee.Empid);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        /// <summary>
        /// this method Deletes the employee from database
        /// </summary>
        /// <param name="Id">The identifier.</param>
        public void DeleteEmployee(int Id)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empid", Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        /// <summary>
        /// it shows all employee.
        /// </summary>
        /// <returns>list of employee</returns>
        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> lstemp = new List<Employee>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employee employee = new Employee();
                    employee.Empid = Convert.ToInt32(rdr["Empid"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Password = rdr["Password"].ToString();
                    lstemp.Add(employee);
                }

                con.Close();
            }

            return lstemp;
        }

        /// <summary>
        /// this method has the logic to Gets the employee by its id.
        /// </summary>
        /// <param name="Empid">The empid.</param>
        /// <returns>employee data</returns>
        public Employee GetEmployeeById(int Empid)
        {
            Employee employee = new Employee();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                string sqlQuery = "SELECT * FROM Employee WHERE Empid= " + Empid;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    employee.Empid = Convert.ToInt32(rdr["Empid"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Password = rdr["Password"].ToString();
                }
            }

            return employee;
        }

        /// <summary>
        /// This method Updates the employee details.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Empid", employee.Empid);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
