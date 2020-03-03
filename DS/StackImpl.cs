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
        private T[] ele;                //// to create a Array
        private int top;                //// for index
        private int max;                //// maximum size 

        /// <summary>
        /// Initialize value instance of class.
        /// </summary>
        /// <param name="size">The size.</param>
        public Stack(int size)
        {
            this.ele = new T[size];
           this.top = -1;
            this.max = size;
        }

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(T data)
        {
            if (this.top == (this.max - 1))
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                this.ele[++this.top] = data;
            }
        }

        /// <summary>
        /// Pops the last data.
        /// </summary>
        /// <returns>Generic type data</returns>
        public T Pop()
        {
            if (this.top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
            else
            {
                Console.WriteLine("Popped from stack " + this.ele[this.top]);
                return this.ele[this.top--];
            }
        }

        /// <summary>
        /// Peeks the data from stack.
        /// </summary>
        /// <returns>the data</returns>
        public T Peek()
        {
            if (this.top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
            else
            {
                Console.WriteLine("Peeked from stack " + this.ele[this.top]);
                return this.ele[this.top];
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
            if (this.top == -1)
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
        /// <returns>the size</returns>
        public int Size()
        {
            return this.top + 1;
        }
    }
}
