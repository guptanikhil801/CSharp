namespace DesignPattern.Structural.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    interface ITransaction
    {
        void Withdraw();
        void Deposit();
        void PinChange();
        void Statement();
    }
}
