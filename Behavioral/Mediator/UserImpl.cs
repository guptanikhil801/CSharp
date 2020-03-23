
namespace DesignPattern.Behavioral.Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class UserImpl : User
    {
        public UserImpl(IChatMediator med, string name) : base(med,name)
        {
            
        }
      
    }
}
