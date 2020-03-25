
namespace DesignPattern.Logger
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class LogBase
    {
        protected readonly object lockobj = new object();
        public abstract void Log(string message);
    }
}
