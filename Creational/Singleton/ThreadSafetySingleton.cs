namespace DesignPattern.Creational.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;
  public  class ThreadSafetySingleton
    {
        private static readonly object obj = new object();
        private ThreadSafetySingleton()
        {
            Console.WriteLine("Singleton class created with thread safety using double lock");
        }
        private static ThreadSafetySingleton TSInstance = null;
        public static ThreadSafetySingleton GetInstanceOfThreadSafetySingleton
        {
            get
            {
                if(TSInstance==null)
                {
                    lock(obj)
                    {
                        if(TSInstance==null)
                        {
                            TSInstance = new ThreadSafetySingleton();
                        }
                    }
                }
                return TSInstance;
            }
        }
    }
}
