// -------------------------------------------------------------------------------------------------------
// <copyright file="ITransaction.cs" company="Bridgelabz">
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
    /// Transaction interface
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// Withdraws method declaration
        /// </summary>
        void Withdraw();

        /// <summary>
        /// Deposits  method declaration
        /// </summary>
        void Deposit();

        /// <summary>
        /// Pinchange method declaration
        /// </summary>
        void PinChange();

        /// <summary>
        /// Statements method declaration.
        /// </summary>
        void Statement();
    }
}
