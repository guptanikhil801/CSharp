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
    public class Apparel : IItemElement
    {
        private string brandName;
        private int price;
        private int quantity;
        public Apparel(string brand, int price, int quantity)
        {
            brandName = brand;
            this.price = price;
            this.quantity = quantity;
        }
        public string GetBrandName()
        {
            return this.brandName;
        }
        public int GetPrice()
        {
            return this.price;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
