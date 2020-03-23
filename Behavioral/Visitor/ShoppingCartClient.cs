// -------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCartClient.cs" company="Bridgelabz">
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
    /// main class to test visitor design pattern
    /// </summary>
    public class ShoppingCartClient
    {
        /// <summary>
        /// Driver method
        /// </summary>
        public static void DriverMethodVisitor()
        {
            IItemElement[] items = new IItemElement[] { new Mobile("Apple Iphone 8", 36000, 2), new Apparel("Flying Machine", 1800, 1), new Mobile("One Plus 7", 33000, 1), new Apparel("Indian Terrain", 2100, 2) };
            int totalprice = CalculateCartPrice(items);
            Console.WriteLine("Your Total Shopping amount to be paid after discount is : " + totalprice + " Rs");
        }

        /// <summary>
        /// Calculates Total shopping price.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>total price </returns>
        private static int CalculateCartPrice(IItemElement[] items)
        {
            ShoppingCartVisitor visitor = new ShoppingCartImpl();
            int totalcartvalue = 0;
            foreach (IItemElement ie in items)
            {
                totalcartvalue = totalcartvalue + ie.Accept(visitor);
            }

            return totalcartvalue;
        }
    }
}
