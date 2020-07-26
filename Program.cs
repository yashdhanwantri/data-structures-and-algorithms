using DataStructureAndAlgorithms.Arrays;
using DataStructureAndAlgorithms.Challenges;
using DataStructureAndAlgorithms.HashTable;
using DataStructureAndAlgorithms.LinkedList;
using System;

namespace DataStructureAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse a String
            //Console.WriteLine(ReverseString.Reverse("My Name is Andy"));
            //Console.WriteLine(ReverseString.Reverse("My Name is Miles"));

            // Merge 2 Sorted Array
            //int[] result = MergeSortedArrays.MergeArrays(new int[] { 1, 4, 9, 13,16,17,18,19,20 }, new int[] { 0, 2, 3, 10, 15,20});
            //foreach (var item in result)
            //    Console.Write($"{item},  ");

            // Find Second Largest Element in an Array
            //int result = SecondLargestElementArray.FindSecondLargestElementArray(new int[] { -3, 1, 5, 10, 3, 7, 3, 8, 9 });
            //Console.WriteLine($"Second Largest Element in an Array is: {result}");

            //LinkedList Implementation
            SinglyLinkedList<int> myLinkedList = new SinglyLinkedList<int>(10);
            myLinkedList.Prepend(10);
            myLinkedList.Append(20);
            myLinkedList.Append(30);
            myLinkedList.Append(40);
            myLinkedList.InsertAt(0, 5);
            myLinkedList.InsertAt(3, 35);
            myLinkedList.InsertAt(6, 55);
            myLinkedList.InsertAt(7, 90);
            myLinkedList.TraverseToIndex(0);
            myLinkedList.TraverseToIndex(1);
            myLinkedList.TraverseToIndex(2);
            myLinkedList.TraverseToIndex(3);
            myLinkedList.TraverseToIndex(4);
            myLinkedList.TraverseToIndex(5);
            myLinkedList.TraverseToIndex(6);
            myLinkedList.TraverseToIndex(7);
            myLinkedList.TraverseToIndex(8);
            myLinkedList.Print();
            Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            myLinkedList.Remove(1);
            myLinkedList.Print();
            Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            myLinkedList.Remove(2);
            myLinkedList.Print();
            Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            myLinkedList.Remove(0);
            myLinkedList.Print();
            Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");

            myLinkedList.Remove(myLinkedList.Length-1);
            myLinkedList.Print();
            Console.WriteLine($"Length of Linked List is: {myLinkedList.Length}");
            Console.WriteLine($"Head of Linked List is: {myLinkedList.Head}");
            Console.WriteLine($"Tail of Linked List is: {myLinkedList.Tail}");
            //ArrayList Implementation
            //MyArrayList.TestMyArrayList();

            //Hash Table Usage
            //MyHashTable hashTable = new MyHashTable(2);
            //hashTable.Set("Pineapple", 50);
            //hashTable.Set("Apple", 10);
            //hashTable.Set("Grapes", 90);
            //Console.WriteLine(hashTable.Get("Pineapple"));
            //Console.WriteLine(hashTable.Get("Apple"));
            //Console.WriteLine(hashTable.Get("Grapes"));
            //hashTable.Print();

            //First Recurring Character

            //Console.WriteLine(FirstRecurringCharacter.FindFirstRecurringCharacter("YashDhanwantri"));

        }
    }  
}
 