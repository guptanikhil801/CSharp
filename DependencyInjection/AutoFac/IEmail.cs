// -----------------------------------------------------------------------------------------------------------
// <copyright file="IEmail.cs" company="Bridgelabz">
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
    /// Interface for Email
    /// </summary>
    public interface IEmail
    {
        /// <summary>
        /// to execute email notification
        /// </summary>
        void Execute();
    }
}
