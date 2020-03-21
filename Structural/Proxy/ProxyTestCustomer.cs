﻿// -------------------------------------------------------------------------------------------------------
// <copyright file="ProxyTestCustomer.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Structural.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Customer class to test Proxy design pattern
    /// </summary>
    public class ProxyTestCustomer
    {
        /// <summary>
        /// Driver method
        /// </summary>
        public static void DriverProxydp()
        {
            ProxyCardClass test = new ProxyCardClass();
            Console.WriteLine("Enter Card Type");
            string ct = Console.ReadLine();
            test.StartTransaction(ct);
        }
    }
}
