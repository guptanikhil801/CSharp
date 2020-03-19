﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Management.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------
namespace OopsPrograms.CommercialData
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// to create stock account data type
    /// </summary>
    public class StockAccount
    {
        public string customerName { get; set; }
        public int numberofStocks { get; set; }
        public List<string> transactiontype { get; set; }
        public List<string> shareName { get; set; }
        public List<int> numberofshare { get; set; }
        public int[] shareamountindollar { get; set; }
        public List<int> sharePrice { get; set; }
        public DateTime transactiontime { get; set; }
        public double valueof { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return (string.Format("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", customerName, numberofStocks, transactiontime, shareName, numberofshare, sharePrice, shareamountindollar, transactiontype, valueof));
        }
    }
}
