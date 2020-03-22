// -------------------------------------------------------------------------------------------------------
// <copyright file="ObservorDpTest.cs" company="Bridgelabz">
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
    /// To test observer Design pattern
    /// </summary>
    public class ObservorDpTest
    {
        /// <summary>
        /// driver method.
        /// </summary>
        public static void ObservorDpDriverMethod()
        {
            MakeMyTrip test = new MakeMyTrip();
            Customer c1 = new Customer("Nikhil", 9031378339);
            Customer c2 = new Customer("Gupta", 8603020007);
            Customer c3 = new Customer("Krishna", 9877045632);
            test.CustomerDatabase(c1);
            test.CustomerDatabase(c2);
            test.CustomerDatabase(c3);
            c1.OfferNotification();
            c1.PriceNotification();
            c2.OfferNotification();
            c2.PriceNotification();
            c3.OfferNotification();
            c3.PriceNotification();
        }
    }
}
