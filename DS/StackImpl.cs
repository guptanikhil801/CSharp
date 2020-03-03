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
        public T[] Ele;                //// to create a Array
        public int Top;                //// for index
       public int Max;                //// Maximum size 

        /// <summary>
        /// Initialize value instance of class.
        /// </summary>
        /// <param name="size">The size.</param>
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

        /// <summary>
        /// Pops the last data.
        /// </summary>
        /// <returns>Generic type data</returns>
        public T Pop()
        {
            if (Top == -1)
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

        /// <summary>
        /// Peeks the data from stack.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
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
        /// <summary>
        /// Returns Size of the stack.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return Top + 1;
        }

    }

}
