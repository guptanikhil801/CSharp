// -------------------------------------------------------------------------------------------------------
// <copyright file="AccountManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace FundooManager.ImplementationClassManager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using FundooManager.InterfaceManager;
    using Common.UserModel;
    using FundooRepository.InterfaceRepo;
    

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
        public bool Login(LoginModel manager)
        {
            return this.accountrepo.Login(manager);
        }

        /// <summary>
        /// Does the registration.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <returns>
        /// the user
        /// </returns>
        public void Registration(RegistrationModel manager)
        {
             this.accountrepo.Registration(manager);
        }

        /// <summary>
        /// Forgot password method.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// boolean value
        /// </returns>
       // public bool ForgotPasswordUser(string email, string url)
        //{
      //      return this.accountrepo.ForgotPasswordUser(email, url);
        //}

    
       
    }
}
