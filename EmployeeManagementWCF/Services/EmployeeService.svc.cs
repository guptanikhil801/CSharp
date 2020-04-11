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
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Data;
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
                cmd.Parameters.AddWithValue("@EmpId", id);
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

        public DataSet EmployeeDetailsById(int id)
        {
                DataSet dset = new DataSet();
                SqlCommand cmd = new SqlCommand("spGetEmployeeByIdWcf", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", id);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dset);
                cmd.ExecuteNonQuery();
                con.Close();
                return dset;
        }

        public DataSet GetEmployeeDetails()
        {
            DataSet dset = new DataSet();
            SqlCommand cmd = new SqlCommand("spGetEmployeeWcf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dset);
            cmd.ExecuteNonQuery();
            con.Close();
            return dset;
        }

        public string UpdateEmployee(Employee emp)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployeeWcf", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Password", emp.Password);
                cmd.Parameters.AddWithValue("@DeptId", emp.DeptId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Employee Data updated successfully";
            }
            catch(Exception)
            {
                result = "Invalid data entered";
            }

            return result;
        }
    }
}
