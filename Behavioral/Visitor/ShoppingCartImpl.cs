
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
                value = (mobile.GetPrice() - 500)*mobile.GetQuantity();   //// 500 discount in each if price is over 10000
            }
            else
            {
               value =  mobile.GetPrice() * mobile.GetQuantity();   //// else no discount
            }
            Console.WriteLine("Total Price of Mobile : " + mobile.GetModelName() + " is " + value + " and quantity is " + mobile.GetQuantity());
            return value;
        }

        public int Visit(Apparel apparel)
        {
            int value = 0;
            if(apparel.GetPrice()*apparel.GetQuantity()>2000)
            {
                value = (apparel.GetPrice() * apparel.GetQuantity()) - 100;      //// Rs 100 discount if total apparel valued over 2000
            }
            else
            {
                value = apparel.GetPrice() * apparel.GetQuantity();  //// else no discount
            }
            return value; 
        }
    }
}
