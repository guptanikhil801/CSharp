// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stock.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms.Stock
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class to create object of type stock
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Gets or sets ShareName
        /// </summary>
        public string ShareName { get; set; }

        /// <summary>
        /// Gets or sets number of Share
        /// </summary>
        public int Numberofshare { get; set; }

        /// <summary>
        /// Gets or sets Share price
        /// </summary>
        public double SharePrice { get; set; }

        /// <summary>
        /// Gets or sets value of stock
        /// </summary>
        public double Stockvalue { get; set; }

        /// <summary>
        /// to override string
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            return string.Format("Stockname:\t{0}\nNumber of share:\t{1}\nSharePrice:\t{2}\nTotal stock price:\t{3}", this.ShareName, this.Numberofshare, this.SharePrice, this.Stockvalue);
        }
    }

    /// <summary>
    /// class to create list of stock
    /// </summary>
    public class Portfolio
    {
        /// <summary>
        /// list type stock
        /// </summary>
        public List<Stock> Portfoliodata;

        /// <summary>
        /// Gets or sets value of whole portfolio
        /// </summary>
        public double Portfoliovalue { get; set; }
    }
}
