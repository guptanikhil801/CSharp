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
    public class ProxyCardClass
    {
        private Cash cash = new Cash();
        private static List<string> eligiblecards;

        public void StartTransaction(string cardtype)
        {
            eligiblecards = new List<string>();
            eligiblecards.Add("rupay");
            eligiblecards.Add("visa");
            eligiblecards.Add("master");
            if (eligiblecards.Contains(cardtype.ToLower()))
            {
                cash.Statement();
                cash.Deposit();
                cash.Withdraw();
                cash.PinChange();
            }
            else
            {
                Console.WriteLine("Invalid Card type");
            }
        }
    }
}


