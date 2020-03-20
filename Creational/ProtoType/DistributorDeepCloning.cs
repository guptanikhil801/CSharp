// -----------------------------------------------------------------------------------------
// <copyright file="DistributorDeepCloning.cs" company="Bridgelabz">
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
    /// class for deep cloning
    /// </summary>
    /// <seealso cref="DesignPattern.Creational.ProtoType.DistributorShallowCloning" />
    public class DistributorDeepCloning : DistributorShallowCloning
    {
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// copy of this instance.
        /// </returns>
        public new object Clone()
        {
            DistributorDeepCloning dpc = (DistributorDeepCloning)this.MemberwiseClone();
            dpc.vehicle = (Vehicle)this.vehicle.Clone();
            return dpc;
        }
    }
}
