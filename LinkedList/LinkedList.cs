using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.LinkedList
{
    public class LinkedList<T>
    {
        public Node Head { get; set; }

        public void InsertFront(T data)
        {
            Node node = new Node(data);
            node.Next = Head;
            this.Head = node;
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
        public void InsertLast(T data)
        {
            Node node = new Node(data);

            Node nextNode = Head;
            while (nextNode.Next != null)
            {
                nextNode = nextNode.Next;
            }
            nextNode.Next = node;
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
        }
    }
}
