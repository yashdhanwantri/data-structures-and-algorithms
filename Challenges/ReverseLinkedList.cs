using DataStructureAndAlgorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Challenges
{
    class ReverseLinkedList
    {
        public static SinglyLinkedList<int> ReverseLinkList(SinglyLinkedList<int> linkedList)
        {
            SinglyLinkedList<int> resultLinkedList = null;
            var currentElement = linkedList.Tail;
            
            for(int i=linkedList.Length-1; i>=0; i--)
            {
                if (i == linkedList.Length - 1)
                    resultLinkedList = new SinglyLinkedList<int>(linkedList.Tail.Data);
                else
                {
                    var node = linkedList.TraverseToIndex(i);
                    resultLinkedList.Append(node.Data);
                }
            }
            return resultLinkedList;
        }

        public static void ReverseLinkListVer2(SinglyLinkedList<int> linkedList)
        {
            if(linkedList.Head.Next!=null)
            {
                var firstNode = linkedList.Head;
                var secondNode = firstNode.Next;
                while (secondNode.Next != null)
                {
                    firstNode.Next = secondNode.Next;
                    secondNode.Next = linkedList.Head;
                    linkedList.Head = secondNode;
                    secondNode = firstNode.Next;
                }
                secondNode.Next = linkedList.Head;
                linkedList.Head = secondNode;
                firstNode.Next = null;
                linkedList.Tail = firstNode;
                
            }
                
        }
    }
}
