// -------------------------------------------------------------------------------------------------------
// <copyright file="IAddressBook.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Structural.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// address book interface
    /// </summary>
    public interface IAddressBook
    {
        /// <summary>
        /// abstract method to do operation
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        void DoOperation(string filepath);
    }
}
