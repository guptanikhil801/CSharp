// -------------------------------------------------------------------------------------------------------
// <copyright file="Seller.cs" company="Bridgelabz">
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
    /// this class has list of product
    /// </summary>
    public class Seller
    {
        /// <summary>
        /// Gets the list of products.
        /// </summary>
        /// <returns>product list</returns>
        public List<string> GetListOfproducts()
        {
            List<string> products = new List<string>();
            products.Add("Television");
            products.Add("Mobile");
            products.Add("Shirts");
            products.Add("Spare parts");
            products.Add("sunglass");
            return products;
        }
    }
}
