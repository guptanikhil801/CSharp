// -----------------------------------------------------------------------------------------------------------
// <copyright file="EmailService.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.AutoFac
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// implementation class of IEmail
    /// </summary>
    /// <seealso cref="DesignPattern.DependencyInjection.AutoFac.IEmail" />
    public class EmailService : IEmail
    {
        /// <summary>
        /// method to execute email service
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("You have a new Mail");
        }
    }
}
