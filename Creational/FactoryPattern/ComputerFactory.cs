// -----------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
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
    /// to create instances
    /// </summary>
    public class ComputerFactory
    {
        /// <summary>
        /// Gets the instance of computer.
        /// </summary>
        /// <param name="instancetype">The instance type.</param>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        /// <param name="mfn">The MFN.</param>
        /// <returns>the instance</returns>
        public static IComputer GetInstanceOfComputer(string instancetype, int ram, int hdd, string cpu, string mfn)
        {
            if (instancetype.Equals("pc"))
            {
                return new Pc(ram, hdd, cpu, mfn);
            }
            else if (instancetype.Equals("server"))
            {
                return new Server(ram, hdd, cpu, mfn);
            }
            else
            {
                Console.WriteLine("Invalid Computer type");
                return null;
            }
        }
    }
}
