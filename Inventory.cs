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
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the price of Rice
        /// </summary>
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format("name:\t{0}\nPrice per KG:\t{1}\nWeight:\t{2}", this.Name, this.Price, this.Weight);
        }
    }


public class Inventory
{
    public List<FoodItems> Rice;
    public List<FoodItems> Pulses;
    public List<FoodItems> Weights;

}
   
}

