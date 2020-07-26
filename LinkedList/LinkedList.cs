using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.LinkedList
{
    public class LinkedList<T>
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Length { get; private set; }
        public void InsertFront(T data)
        {
            this.Head = new Node(data) { Next = Head };
            this.Length++;
        }
        public void RemoveFirst()
        {
            Head = Head.Next;
        }
        public void InsertAt(int index, T data)
        {
            Node node = new Node(data);
            int currentIndex = 0;
            Node insertAfter = Head;
            while (currentIndex + 1 != index)
            {
                insertAfter = insertAfter.Next;
                currentIndex += 1;
            }

            node.Next = insertAfter.Next;
            insertAfter.Next = node;
        }
        public void Append(T data)
        {
            this.Tail.Next = new Node(data);
            this.Tail = Tail.Next;
            this.Length++;
        }

        public void Print()
        {
            Node node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data)
            {
                Data = data;
                Next = null;
            }
            public override string ToString()
            {
                return $"{Data}";
            }
        }
    }
}
