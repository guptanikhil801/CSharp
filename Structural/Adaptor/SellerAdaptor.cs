// -------------------------------------------------------------------------------------------------------
// <copyright file="SellerAdaptor.cs" company="Bridgelabz">
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
    /// Adaptor class of seller
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Adaptor.IWebsite" />
   public class SellerAdaptor : IWebsite
    {
        /// <summary>
        /// Gets the product list.
        /// </summary>
        /// <returns>
        /// list of product
        /// </returns>
        public List<string> GetProducts()
        {
            Seller sp = new Seller();
            return sp.GetListOfproducts();
        }
    }
}
