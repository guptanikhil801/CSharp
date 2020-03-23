
namespace DesignPattern.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Mobile : IItemElement
    {
        private string modelName;
        private int price;
        private int quantity;
        public Mobile(string model, int price, int quantity)
        {
            modelName = model;
            this.price = price;
            this.quantity = quantity;
        }
        public string GetModelName()
        {
            return this.modelName;
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
           
        }
    }
}
