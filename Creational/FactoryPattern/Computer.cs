// -----------------------------------------------------------------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.Creational.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// computer interface
    /// </summary>
    public interface IComputer
    {
        /// <summary>
        /// Ram capacity of the instance.
        /// </summary>
        /// <returns>Ram capacity</returns>
        int Ramcapacity();

        /// <summary>
        /// Hard disk capacity of the instance.
        /// </summary>
        /// <returns>Hard disk capacity</returns>
        int Hddcapacity();

        /// <summary>
        /// Cpu names this instance.
        /// </summary>
        /// <returns>Cpu name</returns>
        string Cpuname();

        /// <summary>
        /// Manufacturers this instance.
        /// </summary>
        /// <returns>the Manufacturer</returns>
        string Manufacturer();
    }
}