// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inventory.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------------------- 
namespace OopsPrograms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// this class contains code for creating inventory Json file
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Rice class 
        /// </summary>
        public class Rice
        {
            /// <summary>
            /// Gets or sets the Name of Rice
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the weight of Rice
            /// </summary>
            public int Weight { get; set; }

            /// <summary>
            /// Gets or sets the price of Rice
            /// </summary>
            public double Price { get; set; }
        }
       
        /// <summary>
        /// class for Pulses
        /// </summary>
        public class Pulses
        {
            /// <summary>
            /// Gets or sets the Name of Pulses
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the weight of Pulses
            /// </summary>
            public int Weight { get; set; }

            /// <summary>
            /// Gets or sets the price of Pulses
            /// </summary>
            public double Price { get; set; }
        }

        /// <summary>
        /// class for Wheat
        /// </summary>
      public class Wheat
        {
            /// <summary>
            /// Gets or sets the Name of Wheat
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the weight of Wheat
            /// </summary>
            public int Weight { get; set; }

            /// <summary>
            /// Gets or sets the price of Wheat
            /// </summary>
            public double Price { get; set; }
        }
    }
}
