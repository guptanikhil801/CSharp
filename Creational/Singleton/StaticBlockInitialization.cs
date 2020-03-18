
namespace DesignPattern.Creational.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StaticBlockInitialization
    {
        private static StaticBlockInitialization sInstance;
        private StaticBlockInitialization()
        {
            Console.WriteLine("singleton design pattern using static block");
        }
        static StaticBlockInitialization()
        {
            sInstance = new StaticBlockInitialization();
        }
        public static StaticBlockInitialization GetInstance()
        {
            return sInstance;
        }
    }

}

