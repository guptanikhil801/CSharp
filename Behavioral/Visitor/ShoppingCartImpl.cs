
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
            if(mobile.GetPrice()>20000)
            {
                value = (mobile.GetPrice() - 1000)*mobile.GetQuantity();   //// 1000 discount in each if price is over 20000
            }
            else
            {
               value =  mobile.GetPrice() * mobile.GetQuantity();   //// else no discount
            }
            Console.WriteLine("Total Price of Mobile : " + mobile.GetModelName() + " is " + value + " and quantity is " + mobile.GetQuantity()+", discount : "+1000*mobile.GetQuantity());
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
            Console.WriteLine("Total Price of Apparel : " + apparel.GetBrandName() + " is " + value + " and quantity is " +apparel.GetQuantity());
            return value; 
        }
    }
}
