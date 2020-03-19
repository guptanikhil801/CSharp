// -----------------------------------------------------------------------------------------------------------
// <copyright file="Server.cs" company="Bridgelabz">
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
    /// implementation class of IComputer
    /// </summary>
    /// <seealso cref="DesignPattern.Creational.FactoryPattern.IComputer" />
    public class Server : IComputer
    {
        /// <summary>
        /// The Ram
        /// </summary>
        private int ram;

        /// <summary>
        /// The Hard disk
        /// </summary>
        private int hdd;

        /// <summary>
        /// The cpu
        /// </summary>
        private string cpu;

        /// <summary>
        /// The manufacturer
        /// </summary>
        private string manuf;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        /// <param name="manuf">The manufacturer.</param>
        public Server(int ram, int hdd, string cpu, string manuf)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
            this.manuf = manuf;
        }

        /// <summary>
        /// Cpu names of this instance.
        /// </summary>
        /// <returns>
        /// Cpu name
        /// </returns>
        public string Cpuname()
        {
            return this.cpu;
        }

        /// <summary>
        /// Hard disk capacity of the instance.
        /// </summary>
        /// <returns>
        /// Hard disk capacity
        /// </returns>
        public int Hddcapacity()
        {
            return this.hdd;
        }

        /// <summary>
        /// Manufacturer of  this instance.
        /// </summary>
        /// <returns>
        /// the Manufacturer
        /// </returns>
        public string Manufacturer()
        {
            return this.manuf;
        }

        /// <summary>
        /// Ram capacity of the instance.
        /// </summary>
        /// <returns>
        /// Ram capacity
        /// </returns>
        public int Ramcapacity()
        {
            return this.ram;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Manufactured by: " + this.manuf + " Ram : " + this.ram + " Hard Disk: " + this.hdd + " Cpu: " + this.cpu;
        }
    }
}