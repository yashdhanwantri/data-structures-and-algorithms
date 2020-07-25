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
            //LinkedList<int> myLinkedList = new LinkedList<int>();
            //myLinkedList.InsertFront(10);
            //myLinkedList.InsertLast(20);
            //myLinkedList.InsertLast(30);
            //myLinkedList.InsertLast(40);

            //myLinkedList.Print();
            //myLinkedList.InsertAt(3, 25);

            //myLinkedList.Print();

            //ArrayList Implementation
            //MyArrayList.TestMyArrayList();

            //Hash Table Usage
            MyHashTable hashTable = new MyHashTable(50);
            hashTable.set("Pineapple", 50);
            hashTable.set("Apple", 10);
            Console.WriteLine(hashTable.get("Pineapple"));
            Console.WriteLine(hashTable.get("Apple"));
            Console.WriteLine(hashTable.get("Grapes"));
            
        }
    }  
}
 