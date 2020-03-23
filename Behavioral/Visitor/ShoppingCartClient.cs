
namespace DesignPattern.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public class ShoppingCartClient
    {
        private static int CalculateCartPrice(IItemElement[] items)
        {
            ShoppingCartVisitor visitor = new ShoppingCartImpl();
            int totalcartvalue = 0;
            foreach(IItemElement ie in items)
            {
                totalcartvalue = totalcartvalue + ie.Accept(visitor);
            }
            return totalcartvalue;
        }
    }
}
