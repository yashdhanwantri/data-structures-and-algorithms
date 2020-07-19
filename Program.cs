using DataStructureAndAlgorithms.Arrays;
using System;

namespace DataStructureAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ReverseString.Reverse("My Name is Andy"));
            //Console.WriteLine(ReverseString.Reverse("My Name is Miles"));

            int[] result = MergeSortedArrays.MergeArrays(new int[] { 1, 4, 9, 13,16,17,18,19,20 }, new int[] { 0, 2, 3, 10, 15,20});
            foreach (var item in result)
                Console.Write($"{item},  ");
        }
    }  
}
 