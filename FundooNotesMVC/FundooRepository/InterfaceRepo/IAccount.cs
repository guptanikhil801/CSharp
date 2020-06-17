// -------------------------------------------------------------------------------------------------------
// <copyright file="IAccount.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace FundooRepository.InterfaceRepo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Common.UserModel;
    

    /// <summary>
    /// Interface for operations in Account
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// method for login.
        /// </summary>
        /// <param name="loginmodel">The loginmodel.</param>
        /// <returns>the user</returns>
        bool Login(LoginModel loginmodel);

        /// <summary>
        /// Does the registration.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>new user</returns>
        void Registration(RegistrationModel model);

        /// <summary>
        /// method for Reset password
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="url">The URL.</param>
        /// <returns>boolean value</returns>
        void ResetPassword(ResetPasswordModel model);

        bool ForgotPasswordUser(ForgotPassword model, string url);
        string GetProfilePic(string email);
   
    }
}
