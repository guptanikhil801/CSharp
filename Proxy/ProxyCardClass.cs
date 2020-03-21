// -------------------------------------------------------------------------------------------------------
// <copyright file="ProxyCardClass.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Structural.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class to hold object of cash class
    /// </summary>
    public class ProxyCardClass
    {
        private static List<string> eligiblecards;
        private Cash cash = new Cash();

        /// <summary>
        /// Starts the transaction.
        /// </summary>
        /// <param name="cardtype">The card type.</param>
        public void StartTransaction(string cardtype)
        {
            eligiblecards = new List<string>();
            eligiblecards.Add("rupay");
            eligiblecards.Add("visa");
            eligiblecards.Add("master");
            if (eligiblecards.Contains(cardtype.ToLower()))
            {
                this.cash.Statement();
                this.cash.Deposit();
                this.cash.Withdraw();
                this.cash.PinChange();
            }
            else
            {
                Console.WriteLine("Invalid Card type");
            }
        }
    }
}