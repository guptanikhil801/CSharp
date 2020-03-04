﻿namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class has code for implementation of Dequeue
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class Dequeue<T>
    {
        /// <summary>
        /// defining the node
        /// </summary>
        public class Node
        {
            public T Data;
            public Node Next;
        }

        public Node Head;

        /// <summary>
        /// Adds the data to rear position.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddRear(T data)
        {
            Node node = new Node();        //// create a new node
            node.Data = data;             //// set default values
            node.Next = null;            //// set default values

            //// check that is the list is empty or not, if empty then node will become Head
            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                Node t = this.Head;           ////  assign Head to a temporary Node type variable
                ////  this loop will continue till second last node
                while (t.Next != null)
                {
                    t = t.Next;       //// the value of t will keep changing
                }

                t.Next = node;
            }
        }

        /// <summary>
        /// Adds the data to front.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddFront(T data)
        {
            Node node = new Node();
            node.Data = data;
            node.Next = null;
            this.Head = node;
        }

        /// <summary>
        /// Returns the Size 
        /// </summary>
        /// <returns>total size</returns>
        /// <exception cref="NullReferenceException">if head is null</exception>
        public int Size()
        {
            int count = 0;
            Node t = this.Head;
            //// if Head is null then it will return size 0 
            if (this.Head == null)
            {
                return 0;
                throw new NullReferenceException();
            }
            else
            {
                //// the loop will continue till the second last node
                while (t.Next != null)
                {
                    count++;                             //// the value of size will increment after every iteration 
                    t = t.Next;
                }

                count = count + 1;                       //// count = count+1 because above loop will traverse till second last node
            }

            return count;
        }

        /// <summary>
        /// Removes the rear data.
        /// </summary>
        /// <returns>last data</returns>
        public T RemoveRear()
        {
            if (this.Head == null)
            {
                return default;
            }

            Node t = this.Head, pre = null;

            while (t.Next != null)
            {
                pre = t;
                t = t.Next;
            }

            T data = t.Data;
            pre.Next = null;
            return data;
        }

        /// <summary>
        /// Removes the front data.
        /// </summary>
        /// <returns>front data</returns>
        public T RemoveFront()
        {
            if (this.Head == null)
            {
                Console.WriteLine("que is Empty");
                return default;
            }

            T data = this.Head.Data;
            this.Head = this.Head.Next;
            return data;
        }

        /// <summary>
        /// Determines whether this Dequeue is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (this.Size() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
