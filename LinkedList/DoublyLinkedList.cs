using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.LinkedList
{
    class DoublyLinkedList<T>
    {
        public DoublyLinkedList(T data)
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
            Head.Previous = new Node(data) { Next = Head };
            Head = Head.Previous;
            this.Length++;
            Console.WriteLine($"{data} inserted on front of Linked List, new Head Node is: {Head.Data} and Tail Node is: {Tail.Data} Length: {Length}");
        }
        public void Remove(int index)
        {
            if (index < 0 || index > Length - 1)
                throw new IndexOutOfRangeException("Index Out of Bounds");
            if (index == 0)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else if (index == Length - 1)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Node nodeToRemove;
                Node previousNode;
                Node nextNode;
                if (index >= Length / 2)
                {
                    nodeToRemove = TraverseToNodeFromEnd(index);
                }
                else
                {
                    nodeToRemove = TraverseToNodeFromBeginning(index);
                }
                previousNode = nodeToRemove.Previous;
                nextNode = nodeToRemove.Next;
                previousNode.Next = nextNode;
                nextNode.Previous = previousNode;
                nodeToRemove.Next = null;
                nodeToRemove.Previous = null;
            }
            Length--;
            Console.WriteLine($"Node at index {index} Removed Successfully! Length: {Length}. Head: {Head}. Tail: {Tail}");

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
            else if (index > Length || index < 0)
                throw new IndexOutOfRangeException("Index is out of range");
            else
            {
                Node nodeToInsert = new Node(data);
                Node nodeAtIndex;
                Node previousNode;
                if (index >= Length / 2)
                    nodeAtIndex = TraverseToNodeFromEnd(index);
                else
                    nodeAtIndex = TraverseToNodeFromBeginning(index);
                previousNode = nodeAtIndex.Previous;
                previousNode.Next = nodeToInsert;
                nodeToInsert.Previous = previousNode;
                nodeToInsert.Next = nodeAtIndex;
                nodeAtIndex.Previous = nodeToInsert;
                Length++;
            }
            Console.WriteLine($"{data} inserted at Index {index}. Length: {Length}. Head: {Head}. Tail: {Tail}");
        }

        public Node TraverseToNodeFromBeginning(int index)
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

        public Node TraverseToNodeFromEnd(int index)
        {
            var nodeToReturn = Tail;
            if (index < 0 || index > Length)
                throw new IndexOutOfRangeException("Index is invalid");
            if (index == Length - 1) { }

            else if (index == 0)
                nodeToReturn = Head;
            else
            {
                int currentIndex = Length - 1;
                while (currentIndex != index)
                {
                    nodeToReturn = nodeToReturn.Previous;
                    currentIndex--;
                }
            }
            Console.WriteLine($"Node {index} is {nodeToReturn.Data}");
            return nodeToReturn;
        }
        public void Append(T data)
        {
            Node nodeToAppend = new Node(data) { Previous = Tail };
            Tail.Next = nodeToAppend;
            Tail = nodeToAppend;
            this.Length++;
            Console.WriteLine($"{data} appended on Linked List, new Head Node is: {Head.Data} and Tail Node is: {Tail.Data} Length: {Length}");
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
            public Node Previous { get; set; }
            public Node(T data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
            public override string ToString()
            {
                return $"{Data}";
            }
        }
    }
}