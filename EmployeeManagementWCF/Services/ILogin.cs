// -------------------------------------------------------------------------------------------------------
// <copyright file="ILogin.cs" company="Bridgelabz">
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

    /// <summary>
    /// Interface for Login Service
    /// </summary>
    [ServiceContract]
    public interface ILogin
    {
        /// <summary>
        /// method for Login authentication.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>boolean value</returns>
        [OperationContract]
        bool LoginAuthentication(string email, string password);
    }
}
