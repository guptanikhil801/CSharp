// -------------------------------------------------------------------------------------------------------
// <copyright file="EcommerceCompany.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Structural.Adaptor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// client class
    /// </summary>
    public class EcommerceCompany
    {
        /// <summary>
        /// Driver method.
        /// </summary>
        public static void DriverMethod()
        {
            IWebsite web = new SellerAdaptor();
            Console.WriteLine("Product List");
            foreach (string product in web.GetProducts())
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
        }
    }
}
