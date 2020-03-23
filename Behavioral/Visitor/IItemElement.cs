
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
