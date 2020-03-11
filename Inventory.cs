namespace OopsPrograms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// this class contains code for creating inventory json file
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Rice class 
        /// </summary>
        public class Rice
        {
            /// <summary>
            ///Gets or sets the Name of Rice
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
        public class Pulses
        {
            /// <summary>
            ///Gets or sets the Name of Pulses
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

      public  class Wheats
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public double Price { get; set; }
        }

    }
}
