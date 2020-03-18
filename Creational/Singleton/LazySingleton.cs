namespace DesignPattern.Creational.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public sealed class LazySingleton
    {
        private LazySingleton()
        {
            Console.WriteLine("Singleton class created using Lazy Initialization ");
        }
        private static readonly Lazy<LazySingleton> LSInstance = new Lazy<LazySingleton>(() => new LazySingleton());
        public static LazySingleton getInstanceOfLazySingleton
        {
            get
            {
                return LSInstance.Value;
            }
        }
    }
}
