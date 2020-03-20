// -----------------------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------
namespace DesignPattern.Creational.ProtoType
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// vehicle class 
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class Vehicle : ICloneable
    {
        public string Typeofvehicle;
        public string Brand;
        public int Price;

        /// <summary>
        /// Initializes a new instance of the vehicle <see cref="Vehicle"/> class.
        /// </summary>
        /// <param name="typeofvehicle">The type of vehicle.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="price">The price.</param>
        public Vehicle(string typeofvehicle, string brand, int price)
        {
            this.Typeofvehicle = typeofvehicle;
            this.Brand = brand;
            this.Price = price;
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// copy of this instance.
        /// </returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "  Type : " + this.Typeofvehicle + ",  Brand : " + this.Brand + ", Price : " + this.Price;
        }
    }
}