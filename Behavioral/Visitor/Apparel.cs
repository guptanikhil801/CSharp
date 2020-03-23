// -------------------------------------------------------------------------------------------------------
// <copyright file="Apparel.cs" company="Bridgelabz">
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
    /// Apparel class which implements IItemElement interface
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Visitor.IItemElement" />
    public class Apparel : IItemElement
    {
        private string brandName;
        private int price;
        private int quantity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Apparel"/> class.
        /// </summary>
        /// <param name="brand">The brand.</param>
        /// <param name="price">The price.</param>
        /// <param name="quantity">The quantity.</param>
        public Apparel(string brand, int price, int quantity)
        {
            this.brandName = brand;
            this.price = price;
            this.quantity = quantity;
        }

        /// <summary>
        /// Gets the name of the brand.
        /// </summary>
        /// <returns>brand name</returns>
        public string GetBrandName()
        {
            return this.brandName;
        }

        /// <summary>
        /// Gets the price of Apparel.
        /// </summary>
        /// <returns>the price</returns>
        public int GetPrice()
        {
            return this.price;
        }

        /// <summary>
        /// Gets the quantity of Apparel.
        /// </summary>
        /// <returns>quantity of apparels</returns>
        public int GetQuantity()
        {
            return this.quantity;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>the visitor</returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
