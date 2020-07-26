using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.LinkedList
{
    public class SinglyLinkedList<T>
    {

        public SinglyLinkedList(T data)
        {
            Head = new Node(data);
            Tail = Head;
            Length = 1;
        }
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Length { get; private set; }
        public void Prepend(T data)
        {
            this.Head = new Node(data) { Next = Head };
            this.Length++;

            Console.WriteLine($"{data} inserted on front of Linked List, new Head Node is: {Head.Data} and Tail Node is: {Tail.Data}");
        }
        public void Remove(int index)
        {
            if (index < 0 || index > Length-1)
                throw new IndexOutOfRangeException("Index Out of Bounds");
            if (index == 0)
            {
                Head = Head.Next;
                Length--;
                Console.WriteLine($"Node at index 0 Removed Successfully!");
            }
            else
            {
                Node nodeToRemove = Head;
                Node prevNode = null;
                int currentIndex = 0;
                while(currentIndex != index)
                {
                    currentIndex++;
                    prevNode = nodeToRemove;
                    nodeToRemove = nodeToRemove.Next;
                }
                prevNode.Next = nodeToRemove.Next;
                nodeToRemove.Next = null;
                if (index == Length - 1)
                    Tail = prevNode;
                Length--;
                Console.WriteLine($"Node {nodeToRemove.Data} at index {index} Removed Successfully!");
            }

            
        }
        public void InsertAt(int index, T data)
        {
            if (index == 0)
            {
                Prepend(data);
            }
            else if (index == Length)
            {
                Append(data);
            }
            else if (index > Length|| index < 0)
                throw new IndexOutOfRangeException("Index is out of range");
            else
            {   
                int currentIndex = 0;
                Node currentNode = Head;
                while(currentIndex != index-1)
                {
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
                Node nodeToInsert = new Node(data) { Next = currentNode.Next };
                currentNode.Next = nodeToInsert;
                Console.WriteLine($"Node {data} is inserted at {index} position");
                Length++;
            }
        }

        public Node TraverseToIndex(int index)
        {
            var nodeToReturn = Head;
            if (index < 0 || index > Length)
                throw new IndexOutOfRangeException("Index is invalid");
            if (index == 0) { }

            else if (index == Length - 1)
                nodeToReturn = Tail;
            else
            {
                int currentIndex = 0;
                while (currentIndex != index)
                {
                    nodeToReturn = nodeToReturn.Next;
                    currentIndex++;
                }
            }
            Console.WriteLine($"Node {index} is {nodeToReturn.Data}");
            return nodeToReturn;
        }
        public void Append(T data)
        {
            this.Tail.Next = new Node(data);
            this.Tail = Tail.Next;
            this.Length++;
            Console.WriteLine($"{data} appended on Linked List, new Head Node is: {Head.Data} and Tail Node is: {Tail.Data}");
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
