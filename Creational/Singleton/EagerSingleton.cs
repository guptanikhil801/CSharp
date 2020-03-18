namespace DesignPattern.Creational.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public sealed class EagerSingleton
    {
        private EagerSingleton()
        {
            Console.WriteLine("Singleton class created using Eager Initialization ");
        }
    }
}