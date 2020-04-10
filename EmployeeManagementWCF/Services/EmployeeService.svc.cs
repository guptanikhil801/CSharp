using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace EmployeeManagementWCF.Services
{
    public class EmployeeService : IEmployeeService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        public string AddEmployee(Employee emp)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("spAddEmployeeWcf", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Password", emp.Password);
                cmd.Parameters.AddWithValue("@DeptId", emp.DeptId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Employee Data added Successsfully";
            }
            catch (Exception)
            {
                result = "Error occured";
            }
            return result;
        }

        public string DeleteEmployee(int id)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployeeWcf", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empid", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Employee Record deleted successfully";
            }
            catch(Exception)
            {
                result = "Invalid Employee Id";
            }
            return result;
        }

        public Employee EmployeeDetailsById(int id)
        {
            Employee employee = new Employee();
            try
            {
                SqlCommand cmd = new SqlCommand("spGetEmployeeByIdWcf", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    employee.EmpId = Convert.ToInt32(rdr["EmpId"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Password = rdr["Password"].ToString();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("Error:  " + ex);
            }
            return employee;
        }

        public Employee GetEmployeeDetails()
        {
            throw new NotImplementedException();
        }

        public string UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
