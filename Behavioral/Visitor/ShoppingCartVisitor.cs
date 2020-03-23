
// -------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCartVisitor.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public interface ShoppingCartVisitor
    {
        int Visit(Mobile mobile);
        int Visit(Apparel apparel);
    }
}
