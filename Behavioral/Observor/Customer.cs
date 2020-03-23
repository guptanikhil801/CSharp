// -------------------------------------------------------------------------------------------------------
// <copyright file="Customer.cs" company="Bridgelabz">
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
    /// class for observing customer
    /// </summary>
    public class Customer:IObservor
    {
        /// <summary>
        /// The name of customer
        /// </summary>
        private string name;

        /// <summary>
        /// The contact number of customer
        /// </summary>
        private long contactnumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="mobile">The mobile.</param>
        public Customer(string name, long mobile)
        {
            this.name = name;
            this.contactnumber = mobile;
        }

        /// <summary>
        /// for Prices notification.
        /// </summary>
        public void PriceNotification()
        {
            Console.WriteLine("Hey " + this.name + " Price Dropped for flight");
        }

        /// <summary>
        /// for Offers notification.
        /// </summary>
        public void OfferNotification()
        {
            Console.WriteLine("Hey " + this.name + " 35% off for your next Hotel Building");
        }
    }
}