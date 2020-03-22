// -------------------------------------------------------------------------------------------------------
// <copyright file="Observor.cs" company="Bridgelabz">
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
    /// Interface for observor
    /// </summary>
   public interface IObservor
    {
        /// <summary>
        /// Price notification.
        /// </summary>
        public void PriceNotification();

        /// <summary>
        /// Offer notification.
        /// </summary>
        public void OfferNotification();
    }
}
