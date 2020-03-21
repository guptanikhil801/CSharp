// -------------------------------------------------------------------------------------------------------
// <copyright file="Cash.cs" company="Bridgelabz">
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
    /// main class which has funtionality and implements ITransaction
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Proxy.ITransaction" />
    public class Cash : ITransaction
    {
        /// <summary>
        /// to Deposits money
        /// </summary>
        public void Deposit()
        {
            Console.WriteLine("Enter amount to deposit");
            int dep = int.Parse(Console.ReadLine());
            Console.WriteLine(dep+"  deposited ");
        }

        /// <summary>
        /// to change pin
        /// </summary>
        public void PinChange()
        {
            Console.WriteLine("Enter New pin ");
            int pin = int.Parse(Console.ReadLine());
            Console.WriteLine("pin changed to "+pin);
        }

        /// <summary>
        /// to print Statements 
        /// </summary>
        public void Statement()
        {
            Console.WriteLine("Statement :");
            Console.WriteLine("5000 debited at 10-03-2020");
            Console.WriteLine("8000 credited at 20-03-2020");
            Console.WriteLine("current balance : 12500");
        }

        /// <summary>
        /// to Withdraw cash
        /// </summary>
        public void Withdraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            int wid = int.Parse(Console.ReadLine());
            Console.WriteLine(wid + "  withdrawl from your account ");
        }
    }
}
