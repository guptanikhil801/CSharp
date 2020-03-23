// -------------------------------------------------------------------------------------------------------
// <copyright file="IItemElement.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public interface IItemElement
    {
        int Accept(ShoppingCartVisitor visitor);
    }
}
