// -------------------------------------------------------------------------------------------------------
// <copyright file="IWebsite.cs" company="Bridgelabz">
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
    /// main interface between company and seller
    /// </summary>
   public interface IWebsite
    {
        /// <summary>
        /// Gets the product list.
        /// </summary>
        /// <returns>list of product</returns>
        List<string> GetProducts();
    }
}
