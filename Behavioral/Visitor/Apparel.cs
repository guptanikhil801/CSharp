
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
        public int Accept(ShoppingCartVisitor visitor)
        {

        }
    }
}
