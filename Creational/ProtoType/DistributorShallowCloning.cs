// -----------------------------------------------------------------------------------------
// <copyright file="DistributorShallowCloning.cs" company="Bridgelabz">
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
    /// for shallow cloning
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class DistributorShallowCloning : ICloneable
    {
        public string Location;
        public Vehicle vehicle;

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Location : " + this.Location + ", vehicle Details -" + this.vehicle;
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
    }
}