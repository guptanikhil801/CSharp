namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// /This class contains implementations of queue 
    /// </summary>
    /// <typeparam name="T">the t type data</typeparam>
    public class Queue<T>
    {
        
        private T[] queue;
        private int qsize;
        private int front;
        private int rear;
        private int size;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue{T}"/> class.
        /// </summary>
        /// <param name="qsize">The qsize.</param>
        public Queue(int qsize)
        {
            this.qsize = qsize;
            this.queue = new T[qsize];
            this.front = 0;
            this.rear = 0;
            this.size = 0;
        }

        /// <summary>
        /// Adds the specified data to queue.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(T data)
        {
            this.queue[this.rear] = data;
            this.rear++;
            this.size++;
        }

        /// <summary>
        /// Dequeues the data.
        /// </summary>
        /// <returns>the data</returns>
       public T Dequeue()
        {
            if (this.front == this.rear)
            {
                Console.WriteLine("Queue is Empty");
                return default;
            }
            else
            {
                T data = this.queue[this.front++];
                this.size--;
                return data;
            }
        }

        /// <summary>
        /// It returns Size of queue 
        /// </summary>
        /// <returns>size of queue</returns>
        public int Size()
        {
            return this.size;
        }

        /// <summary>
        /// Determines whether queue is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (this.size == 0)
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
