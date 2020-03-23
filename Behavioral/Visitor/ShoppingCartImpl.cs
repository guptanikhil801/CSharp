
namespace DesignPattern.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ShoppingCartImpl : ShoppingCartVisitor
    {
        public int Visit(Mobile mobile)
        {
            int value = 0;
            if(mobile.GetPrice()>10000)
            {
                value = (mobile.GetPrice() - 500)*mobile.GetQuantity();
            }
            else
            {
               value =  mobile.GetPrice() * mobile.GetQuantity();
            }
            Console.WriteLine("Total Price of Mobile : " + mobile.GetModelName() + " is " + value + " and quantity is " + mobile.GetQuantity());
            return value;
        }

        public int Visit(Apparel apparel)
        {
            int value = 0;
            if(apparel.GetPrice()*apparel.GetQuantity()>2000)
            {
                value = (apparel.GetPrice() * apparel.GetQuantity()) - 100;
            }
            else
            {
                value = apparel.GetPrice() * apparel.GetQuantity();
            }
            return value; 
        }

    }
}
