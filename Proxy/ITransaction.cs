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
    /// Transation interface
    /// </summary>
    interface ITransaction
    {
        void Withdraw();
        void Deposit();
        void PinChange();
        void Statement();
    }
}
