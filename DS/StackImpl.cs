namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains code for implementation of stack
    /// </summary>
    public class Stack<T>
    {
        T[] Ele;
        int Top;
        int Max;

        public Stack(int size)
        {
            Ele = new T[size];
            Top = -1;
            Max = size;
        }



    }    

}
