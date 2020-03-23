// -------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCartImpl.cs" company="Bridgelabz">
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
    /// implementation class of ShoppingCartVisitor
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Visitor.ShoppingCartVisitor" />
    public class ShoppingCartImpl : ShoppingCartVisitor
    {
        /// <summary>
        /// visit mobile method.
        /// </summary>
        /// <param name="mobile">The mobile.</param>
        /// <returns>total price of mobile</returns>
        public int Visit(Mobile mobile)
        {
            int value = 0;
            if (mobile.GetPrice() > 20000)
            {
                value = (mobile.GetPrice() - 1000) * mobile.GetQuantity();   //// 1000 discount in each if price is over 20000
            }
            else
            {
                value = mobile.GetPrice() * mobile.GetQuantity();   //// else no discount
            }

            Console.WriteLine("Total Price of Mobile : " + mobile.GetModelName() + " is " + value + " and quantity is " + mobile.GetQuantity() + ", discount : " + 1000 * mobile.GetQuantity());
            return value;
        }

        /// <summary>
        /// Visit apparel method
        /// </summary>
        /// <param name="apparel">The apparel.</param>
        /// <returns>total price of apparel</returns>
        public int Visit(Apparel apparel)
        {
            int value = 0;
            if (apparel.GetPrice() * apparel.GetQuantity() > 2000)
            {
                value = (apparel.GetPrice() * apparel.GetQuantity()) - 100;      //// Rs 100 discount if total apparel valued over 2000
            }
            else
            {
                value = apparel.GetPrice() * apparel.GetQuantity();  //// else no discount
            }

            Console.WriteLine("Total Price of Apparel : " + apparel.GetBrandName() + " is " + value + " and quantity is " + apparel.GetQuantity());
            return value;
        }
    }
}