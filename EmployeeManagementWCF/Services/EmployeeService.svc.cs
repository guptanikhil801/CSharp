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
            throw new NotImplementedException();
        }

       

        public Employee EmployeeDetailsById(int id)
        {
            throw new NotImplementedException();
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
