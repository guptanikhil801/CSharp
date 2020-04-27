// -------------------------------------------------------------------------------------------------------
// <copyright file="IAccountManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace BusinessManager.InterfaceManager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common.UserModel;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Account manager interface
    /// </summary>
    public interface IAccountManager
    {
        /// <summary>
        /// Does the login.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <returns>the user</returns>
        User DoLogin(LoginModel manager);

        /// <summary>
        /// Does the registration.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <returns>the user</returns>
        User DoRegistration(RegistrationModel manager);

        /// <summary>
        /// Forgot password method.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="url">The URL.</param>
        /// <returns>boolean value</returns>
        bool ForgotPasswordUser(string email, string url);

        /// <summary>
        /// Profiles the picture.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="IFormFile">The i form file.</param>
        /// <returns></returns>
        bool ProfilePicture(string email, IFormFile imgfile);
    }
}
