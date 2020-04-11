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

            con.Close();
            return false;
        }
    }
}
