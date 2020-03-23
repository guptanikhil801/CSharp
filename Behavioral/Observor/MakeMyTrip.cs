// -------------------------------------------------------------------------------------------------------
// <copyright file="MakeMyTrip.cs" company="Bridgelabz">
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
    /// subject implementation class
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Observor.Subject" />
    public class MakeMyTrip : ISubject
    {
        /// <summary>
        /// The list of customer
        /// </summary>
        private List<Customer> customer = new List<Customer>();

        /// <summary>
        /// to adds Customers to the database.
        /// </summary>
        /// <param name="cus">The customer.</param>
        public void CustomerDatabase(Customer cus)
        {
            this.customer.Add(cus);
        }
    }
}
