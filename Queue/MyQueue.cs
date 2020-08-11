using DataStructureAndAlgorithms.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Queue
{
    public class QueueNode<T>
    {
        public T Data { get; set; }
        public QueueNode<T> Next { get; set; }
    }
    public class MyQueue<T>
    {
        public QueueNode<T> First { get; private set; }
        public QueueNode<T> Last { get; private set; }
        public int Length { get; private set; }
        public MyQueue()
        {
            First = null;
            Last = null;
            Length = 0;
        }

        public void Enqueue(T Data)
        {
            if (Length == 0)
            {
                First = new QueueNode<T>() { Data = Data };
                Last = First;
            }
            else
            {
                Last.Next = new QueueNode<T>() { Data = Data };
                Last = Last.Next;
            }
            Length++;
            Console.WriteLine($"First Item: {First.Data}. Last Item: {Last.Data}. Length: {Length}");
        }
        public T Dequeue()
        {
            if (Length == 0)
                Console.WriteLine("Queue Empty");
            else
            {
                try
                {
                    Console.WriteLine($"Item: {First.Data} dequeued");
                    var result = First;
                    if (First.Next != null)
                        First = First.Next;
                    Length--;
                    Console.WriteLine($"First Item: {First.Data}. Last Item: {Last.Data}. Length: {Length}");
                    return result.Data;
                }
                catch
                {
                    Console.WriteLine("Queue Empty");
                }
            }
            return default;
        }

        public void Peek()
        {
            if (First != null)
                Console.WriteLine($"First Item: {First.Data}. Last Item: {Last.Data}. Length: {Length}");
            else
                Console.WriteLine("Queue Empty");
        }
    }
}
