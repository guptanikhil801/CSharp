namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// /This class contains implementations of queue Adt
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
            queue = new T[qsize];
            front = 0;
            rear = 0;
            size = 0;
        }
        public void Enqueue(T data)
        {
            queue[rear] = data;
            rear++;
            size++;
        }

        public void print()
        {
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }

        public T Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return default;
            }

            else
            {
                T data = queue[front++];
                size--;
                return data;
            }
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            if (Size() == 0)
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
