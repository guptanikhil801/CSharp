// -------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCartVisitor.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface for ShoppingCartVisitor
    /// </summary>
    public interface ShoppingCartVisitor
    {
        /// <summary>
        /// method for who Visits mobile.
        /// </summary>
        /// <param name="mobile">The mobile.</param>
        /// <returns>total price of mobile</returns>
        int Visit(Mobile mobile);

        /// <summary>
        /// method for who Visits apparel.
        /// </summary>
        /// <param name="apparel">The apparel.</param>
        /// <returns>total price of Apparel</returns>
        int Visit(Apparel apparel);
    }
}
