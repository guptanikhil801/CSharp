// -----------------------------------------------------------------------------------------------------------
// <copyright file="Pc.cs" company="Bridgelabz">
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
    /// pc class
    /// </summary>
    /// <seealso cref="DesignPattern.Creational.FactoryPattern.IComputer" />
    public class Pc : IComputer
    {
        private int ram;
        private int hdd;
        private string cpu;
        private string manuf;
       public Pc (int ram, int hdd, string cpu, string manuf)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
            this.manuf = manuf;
        }
        public string Cpuname()
        {
            return this.cpu;
        }
        public int Hddcapacity()
        {
            return this.hdd;
        }
        public string Manufacturer()
        {
            return this.manuf;
        }
        public int Ramcapacity()
        {
            return this.ram;
        }
        public override string ToString()
        {
            return ("Manufactured by: " + this.manuf + " Ram : " + this.ram + " Hard Disk: " + this.hdd + " Cpu: " + this.cpu);
        }
    }
}