// -------------------------------------------------------------------------------------------------------
// <copyright file="Login.svc.cs" company="Bridgelabz">
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
    /// implementation class of ILogin
    /// </summary>
    /// <seealso cref="EmployeeManagementWCF.Services.ILogin" />
    public class Login : ILogin
    {
        /// <summary>
        /// method for Login authentication.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// boolean value
        /// </returns>
        public bool LoginAuthentication(string email, string password)
        {
            Regex emailval = new Regex("^[A-Za-z]{1,30}[0-9]{0,20}@[A-Za-z]{1,10}.[A-Za-z]{1,10}$");
            Regex passval = new Regex("^[A-Za-z0-9]{4,12}$");
            if (emailval.IsMatch(email) && passval.IsMatch(password))
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("spCheckLoginWcf", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        con.Close();
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
