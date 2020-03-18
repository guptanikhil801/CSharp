// --------------------------------------------------------------------------------------------------------------------
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

    /// <summary>
    /// Example of singleton class using Bill pugh
    /// </summary>
    public class BillPughSingleton
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="BillPughSingleton"/> class from being created.
        /// </summary>
        private BillPughSingleton()
        {
            Console.WriteLine("Billpugh singleton class called");
        }

        /// <summary>
        /// inner class 
        /// </summary>
        private static class InnerClassBillPugh
        {
            /// <summary>
            /// creation of instance of bill pugh
            /// </summary>
            public static readonly BillPughSingleton InstanceOfBillPugh = new BillPughSingleton();
        }

        /// <summary>
        /// Gets the instance of bill pugh.
        /// </summary>
        /// <returns>The instance</returns>
        public static BillPughSingleton GetInstanceOfBillPugh()
        {
            {
                return BillPughSingleton.InnerClassBillPugh.InstanceOfBillPugh;
            }
        }
    }
}
