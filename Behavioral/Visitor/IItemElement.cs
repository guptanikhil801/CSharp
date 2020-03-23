// -------------------------------------------------------------------------------------------------------
// <copyright file="IItemElement.cs" company="Bridgelabz">
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
    /// IItemElement interface for items
    /// </summary>
    public interface IItemElement
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns> visitor</returns>
        int Accept(ShoppingCartVisitor visitor);
    }
}
