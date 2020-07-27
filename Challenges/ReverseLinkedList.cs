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
    }
}
