using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection.AutoFac
{
    public class EmailService : IEmail
    {
        public void Execute()
        {
            Console.WriteLine("You have a new Mail");
        }
    }
}
