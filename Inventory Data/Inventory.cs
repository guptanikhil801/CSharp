// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inventory.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------------------- 
namespace OopsPrograms.InventoryData
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// to create data of inventory
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// data of Rice
        /// </summary> 
        public List<FoodItems> Rice;

        /// <summary>
        /// data of Pulses
        /// </summary>
       public List<FoodItems> Pulses;

        /// <summary>
        /// data of weight
        /// </summary>
        public List<FoodItems> Weights;
    }

    /// <summary>
    /// this class contains code for creating inventory Json file
    /// </summary>
    public class FoodItems
    {
        /// <summary>
        /// Gets or sets the Name of Rice
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the weight of Rice
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the price of Rice
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// to override object 
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            return string.Format("name:\t{0}\nPrice per KG:\t{1}\nWeight:\t{2}", this.Name, this.Price, this.Weight);
        }
    }
}