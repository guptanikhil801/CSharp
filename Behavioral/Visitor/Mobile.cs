// -------------------------------------------------------------------------------------------------------
// <copyright file="Mobile.cs" company="Bridgelabz">
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
    /// the mobile type element
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Visitor.IItemElement" />
    public class Mobile : IItemElement
    {
        private string modelName;
        private int price;
        private int quantity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mobile"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="price">The price.</param>
        /// <param name="quantity">The quantity.</param>
        public Mobile(string model, int price, int quantity)
        {
            this.modelName = model;
            this.price = price;
            this.quantity = quantity;
        }

        /// <summary>
        /// Gets the model name of mobile.
        /// </summary>
        /// <returns>the name</returns>
        public string GetModelName()
        {
            return this.modelName;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns>the price</returns>
        public int GetPrice()
        {
            return this.price;
        }

        /// <summary>
        /// Gets the quantity.
        /// </summary>
        /// <returns>the quantity</returns>
        public int GetQuantity()
        {
            return this.quantity;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>
        /// the visitor
        /// </returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
