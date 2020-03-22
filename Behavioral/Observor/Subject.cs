// -------------------------------------------------------------------------------------------------------
// <copyright file="Subject.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Behavioral.Observor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface for subject
    /// </summary>
   public interface ISubject
    {
        /// <summary>
        /// Customer database.
        /// </summary>
        /// <param name="cus">The customer.</param>
        void CustomerDatabase(Customer cus);
    }
}
