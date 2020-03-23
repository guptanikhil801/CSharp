
namespace DesignPattern.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    interface ShoppingCartVisitor
    {
        int Visit(Mobile mobile);
        int Visit(Apparel apparel);
    }
}
