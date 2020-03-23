﻿
namespace DesignPattern.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    interface IItemElement
    {
        int Accept(ShoppingCartVisitor visitor);
    }
}
