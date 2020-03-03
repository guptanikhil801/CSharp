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
        T[] Ele;                //// to create a Array
        int Top;                //// for index
        int Max;                //// Maximum size 

        public Stack(int size)
        {
            Ele = new T[size];
            Top = -1;
            Max = size;
        }

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(T data)
        {
            if (Top == (Max - 1))
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                Ele[++Top] = data;
            }
        }
        public T Pop()
        {
            if(Top==-1)
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
            else
            {
                Console.WriteLine("Popped from stack " + Ele[Top]);
                return Ele[Top--];
            }
        }

        public T Peek()
        {
            if (Top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
            else
            {
                Console.WriteLine("Peeked from stack " + Ele[Top]);
                return Ele[Top];
            }
        }

        public bool IsEmpty()
        {
            if (Top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            return Top + 1;
        }

    }    

}
