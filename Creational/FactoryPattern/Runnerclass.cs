// -----------------------------------------------------------------------------------------------------------
// <copyright file="RunnerClass.cs" company="Bridgelabz">
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
    /// main class to test factory pattern
    /// </summary>
    public class Runnerclass
    {
        /// <summary>
        /// Driver method.
        /// </summary>
        public static void DriverMethod()
        {
            Console.WriteLine("Enter Instance type");
            string it = Console.ReadLine();
            Console.WriteLine("Enter Ram Capacity");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hard Disk Capacity");
            int hd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Cpu Name");
            string cp = Console.ReadLine();
            Console.WriteLine("Enter Manufacturer Name");
            string mf = Console.ReadLine();
            ComputerFactory.GetInstanceOfComputer(it, r, hd, cp, mf);
            Console.WriteLine("Specifications are");
            Console.WriteLine(ComputerFactory.GetInstanceOfComputer(it, r, hd, cp, mf));
        }
    }
}