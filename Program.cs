using DataStructureAndAlgorithms.Arrays;
using DataStructureAndAlgorithms.Challenges;
using DataStructureAndAlgorithms.HashTable;
using DataStructureAndAlgorithms.LinkedList;
using DataStructureAndAlgorithms.Stack;
using System;

namespace DataStructureAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************Reverse a String*********************
            //Console.WriteLine(ReverseString.Reverse("My Name is Andy"));
            //Console.WriteLine(ReverseString.Reverse("My Name is Miles"));

            //******************** Merge 2 Sorted Array*********************
            //int[] result = MergeSortedArrays.MergeArrays(new int[] { 1, 4, 9, 13,16,17,18,19,20 }, new int[] { 0, 2, 3, 10, 15,20});
            //foreach (var item in result)
            //    Console.Write($"{item},  ");

            //********************Find Second Largest Element in an Array**********************
            //int result = SecondLargestElementArray.FindSecondLargestElementArray(new int[] { -3, 1, 5, 10, 3, 7, 3, 8, 9 });
            //Console.WriteLine($"Second Largest Element in an Array is: {result}");

            //*****************LinkedList Implementation*********************
            //SinglyLinkedList<int> myLinkedList = new SinglyLinkedList<int>(10);
            //myLinkedList.Prepend(10);
            //myLinkedList.Append(20);
            //myLinkedList.Append(30);
            //myLinkedList.Append(40);
            //myLinkedList.InsertAt(0, 5);
            //myLinkedList.InsertAt(3, 35);
            //myLinkedList.InsertAt(6, 55);
            //myLinkedList.InsertAt(7, 90);
            //myLinkedList.TraverseToIndex(0);
            //myLinkedList.TraverseToIndex(1);
            //myLinkedList.TraverseToIndex(2);
            //myLinkedList.TraverseToIndex(3);
            //myLinkedList.TraverseToIndex(4);
            //myLinkedList.TraverseToIndex(5);
            //myLinkedList.TraverseToIndex(6);
            //myLinkedList.TraverseToIndex(7);
            //myLinkedList.TraverseToIndex(8);
            //myLinkedList.Print();
            //Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            //Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            //Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            //myLinkedList.Remove(1);
            //myLinkedList.Print();
            //Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            //Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            //Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            //myLinkedList.Remove(2);
            //myLinkedList.Print();
            //Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            //Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            //Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            //myLinkedList.Remove(0);
            //myLinkedList.Print();
            //Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            //Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            //Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            //myLinkedList.Remove(myLinkedList.Length-1);
            //myLinkedList.Print();
            //Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            //Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            //Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            //*********************Doubly Linked List Implementation*************************
            //DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(10);
            //Console.WriteLine($"Length of Linked List: {doublyLinkedList.Length}. Head Node: {doublyLinkedList.Head}. Tail Node: {doublyLinkedList.Tail}");
            //doublyLinkedList.Print();

            //doublyLinkedList.Append(20);
            //Console.WriteLine($"Length of Linked List: {doublyLinkedList.Length}. Head Node: {doublyLinkedList.Head}. Tail Node: {doublyLinkedList.Tail}");
            //doublyLinkedList.Print();

            //doublyLinkedList.Prepend(5);
            //Console.WriteLine($"Length of Linked List: {doublyLinkedList.Length}. Head Node: {doublyLinkedList.Head}. Tail Node: {doublyLinkedList.Tail}");
            //doublyLinkedList.Print();

            //doublyLinkedList.Append(30);
            //Console.WriteLine($"Length of Linked List: {doublyLinkedList.Length}. Head Node: {doublyLinkedList.Head}. Tail Node: {doublyLinkedList.Tail}");
            //doublyLinkedList.Print();

            //doublyLinkedList.Prepend(4);
            //Console.WriteLine($"Length of Linked List: {doublyLinkedList.Length}. Head Node: {doublyLinkedList.Head}. Tail Node: {doublyLinkedList.Tail}");
            //doublyLinkedList.Print();

            //doublyLinkedList.Append(40);
            //Console.WriteLine($"Length of Linked List: {doublyLinkedList.Length}. Head Node: {doublyLinkedList.Head}. Tail Node: {doublyLinkedList.Tail}");
            //doublyLinkedList.Print();

            //doublyLinkedList.Prepend(3);
            //Console.WriteLine($"Length of Linked List: {doublyLinkedList.Length}. Head Node: {doublyLinkedList.Head}. Tail Node: {doublyLinkedList.Tail}");
            //doublyLinkedList.Print();

            //doublyLinkedList.Remove(3);
            //doublyLinkedList.Print();
            //doublyLinkedList.Remove(0);
            //doublyLinkedList.Print();
            //doublyLinkedList.Remove(doublyLinkedList.Length - 1);
            //doublyLinkedList.Print();
            //doublyLinkedList.Remove(2);
            //doublyLinkedList.Print();

            //doublyLinkedList.InsertAt(2, 20);
            //doublyLinkedList.Print();
            //doublyLinkedList.InsertAt(2, 10);
            //doublyLinkedList.Print();
            //doublyLinkedList.InsertAt(2, 7);
            //doublyLinkedList.Print();
            //doublyLinkedList.InsertAt(0, 3);
            //doublyLinkedList.Print();
            //doublyLinkedList.InsertAt(7, 40);
            //doublyLinkedList.Print();

            //************Reverse A LinkedList*********************

            //SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(10);
            //singlyLinkedList.Append(20);
            //singlyLinkedList.Append(30);
            //singlyLinkedList.Append(40);
            //singlyLinkedList.Append(50);

            //var reversedLinkedList = ReverseLinkedList.ReverseLinkList(singlyLinkedList);
            //reversedLinkedList.Print();
            //Console.WriteLine($"Before Reversing Linked List | Head: {singlyLinkedList.Head}. Tail: {singlyLinkedList.Tail}. Length: {singlyLinkedList.Length}");
            //ReverseLinkedList.ReverseLinkListVer2(singlyLinkedList);
            //singlyLinkedList.Print();
            //Console.WriteLine($"After Reversing Linked List | Head: {singlyLinkedList.Head}. Tail: {singlyLinkedList.Tail}. Length: {singlyLinkedList.Length}");

            //*****************ArrayList Implementation********************
            //MyArrayList.TestMyArrayList();

            //*******************Hash Table Usage********************
            //MyHashTable hashTable = new MyHashTable(2);
            //hashTable.Set("Pineapple", 50);
            //hashTable.Set("Apple", 10);
            //hashTable.Set("Grapes", 90);
            //Console.WriteLine(hashTable.Get("Pineapple"));
            //Console.WriteLine(hashTable.Get("Apple"));
            //Console.WriteLine(hashTable.Get("Grapes"));
            //hashTable.Print();

            //**********First Recurring Character*******************
            //Console.WriteLine(FirstRecurringCharacter.FindFirstRecurringCharacter("YashDhanwantri"));

            //************** Stack Implementation *****************
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(10);
            Console.WriteLine($"Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Push(20);
            Console.WriteLine($"Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Push(30);
            Console.WriteLine($"Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Push(40);
            Console.WriteLine($"Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Push(50);
            Console.WriteLine($"Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Pop();
            Console.WriteLine($"[POP] Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Pop();
            Console.WriteLine($"[POP] Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Pop();
            Console.WriteLine($"[POP] Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Pop();
            Console.WriteLine($"[POP] Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            myStack.Pop();
            try
            {
                myStack.Pop();
                Console.WriteLine($"[POP] Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {   
                myStack.Pop();
                Console.WriteLine($"[POP] Top item: {myStack.Top.Data}. Bottom Item: {myStack.Bottom.Data}. Length: {myStack.Length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine($"Peeking top element: {myStack.Peek()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }  
}
 