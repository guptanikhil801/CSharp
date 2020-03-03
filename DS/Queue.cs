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
        T[] queue;
        int qsize;
        int front;
        int rear;
        int size;

        public Queue(int qsize)
        {
            this.qsize= qsize;
            queue = new T[qsize];
            front = 0;
            rear = 0;
            size = 0;
        }
    }


}
