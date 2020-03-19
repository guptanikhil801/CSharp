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

    public class ComputerFactory
    {
       
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
