// -------------------------------------------------------------------------------------------------------
// <copyright file="ConnectionString.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    
    /// <summary>
    /// This class is for making connection with database
    /// </summary>
    public class ConnectionString
    {
        /// <summary>
        /// The cname variable to use further
        /// </summary>
        private static string cName = @"Data Source=.; Initial Catalog=EmployeeManagement;Integrated Security=true";

        /// <summary>
        /// Gets the Cname.
        /// </summary>
        /// <value>
        /// The name of the CName.
        /// </value>
        public static string CName
        {
            get => cName;
        }
    }
}