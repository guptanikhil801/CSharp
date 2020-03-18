﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BillPughSingleton.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------------------- 
namespace DesignPattern.Creational.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public class BillPughSingleton
    {
        private BillPughSingleton()
        {
            Console.WriteLine("Billpugh singleton class called");
        }
        private static class InnerClassBillPugh
        {
            public static readonly BillPughSingleton InstanceOfBillPugh = new BillPughSingleton();
        }
        public static BillPughSingleton GetInstanceOfBillPugh()
        {

            {
                return BillPughSingleton.InnerClassBillPugh.InstanceOfBillPugh;
            }
        }
    }
}
