// -------------------------------------------------------------------------------------------------------
// <copyright file="AccountManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace BusinessManager.ImplementationClassManager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BusinessManager.InterfaceManager;
    using Common.UserModel;
    using FundooRepository.InterfaceRepo;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// implementation class of IAccountManager
    /// </summary>
    /// <seealso cref="BusinessManager.InterfaceManager.IAccountManager" />
    public class AccountManagerImpl : IAccountManager
    {
        private readonly IAccount accountrepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManagerImpl"/> class.
        /// </summary>
        /// <param name="accountrepo">The accountrepo.</param>
        public AccountManagerImpl(IAccount accountrepo)
        {
            this.accountrepo = accountrepo;
        }

        /// <summary>
        /// Does the login.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <returns>
        /// the user
        /// </returns>
        public User DoLogin(LoginModel manager)
        {
            return this.accountrepo.DoLogin(manager);
        }

        /// <summary>
        /// Does the registration.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <returns>
        /// the user
        /// </returns>
        public User DoRegistration(RegistrationModel manager)
        {
            return this.accountrepo.DoRegistration(manager);
        }

        /// <summary>
        /// Forgot password method.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// boolean value
        /// </returns>
        public bool ForgotPasswordUser(string email, string url)
        {
            return this.accountrepo.ForgotPasswordUser(email, url);
        }

        /// <summary>
        /// returns true if Profile picture upload sucessfull
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="imagefile">The imagefile.</param>
        /// <returns></returns>
        public bool ProfilePicture(string email, IFormFile imagefile)
        {
            return this.accountrepo.ProfilePicture(email, imagefile);
        }
    }
}
