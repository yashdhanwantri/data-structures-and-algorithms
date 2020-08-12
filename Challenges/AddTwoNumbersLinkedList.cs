using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// You are given two non-empty linked lists representing two non-negative integers. 
/// The digits are stored in reverse order and each of their nodes contain a single digit.
/// Add the two numbers and return it as a linked list.
/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
/// Example:
/// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
/// Output: 7 -> 0 -> 8
/// Explanation: 342 + 465 = 807.
/// </summary>
namespace DataStructureAndAlgorithms.Challenges
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class AddTwoNumbersLinkedList
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carryToBeAdded = 0;
            ListNode result = null;
            if (l1.val + l2.val > 9)
            {
                result = new ListNode((l1.val + l2.val) % 10);
                carryToBeAdded = (l1.val + l2.val) / 10;
            }
            else
                result = new ListNode(l1.val + l2.val);
            l1 = l1.next;
            l2 = l2.next;
            var nextResultNode = result;
            while (l1 != null || l2 != null)
            {
                int valueL1 = l1 != null ? l1.val : 0;
                int valueL2 = l2 != null ? l2.val : 0;
                int valueToBeAdded = valueL1 + valueL2 + carryToBeAdded;
                if (valueToBeAdded > 9)
                {
                    nextResultNode.next = new ListNode(valueToBeAdded % 10);
                    carryToBeAdded = valueToBeAdded / 10;
                }
                else
                {
                    nextResultNode.next = new ListNode(valueToBeAdded);
                    carryToBeAdded = 0;
                }
                nextResultNode = nextResultNode.next;
                l1 = l1.next;
                l2 = l2.next;
            }

            if (carryToBeAdded > 0)
                nextResultNode.next = new ListNode(carryToBeAdded);
            return result;
        }
    }
}