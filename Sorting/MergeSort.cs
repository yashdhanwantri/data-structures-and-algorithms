using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DataStructureAndAlgorithms.Sorting
{
    public class MergeSort
    {
        public static int[] Sort(int[] input)
        {
            if (input.Length == 1)
                return input;
            return null;
        }

        public static int[] Merge(int[] left, int[] right)
        {
            //Left and Right Arrays should be sorted

            int[] sortedMergedArray = new int[left.Length + right.Length];
            int leftIndex = 0, rightIndex = 0, sortedArrayIndex = 0 ;
            while(leftIndex<left.Length && rightIndex<right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    sortedMergedArray[sortedArrayIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    sortedMergedArray[sortedArrayIndex] = right[rightIndex];
                    rightIndex++;
                }
                sortedArrayIndex++;
            }

            //Push remaining element
            while(leftIndex<left.Length)
            {
                sortedMergedArray[sortedArrayIndex] = left[leftIndex];
                sortedArrayIndex++;
                leftIndex++;
            }
            while(rightIndex<right.Length)
            {
                sortedMergedArray[sortedArrayIndex] = right[rightIndex];
                sortedArrayIndex++;
                rightIndex++;
            }
            return sortedMergedArray;
        }

        private Dictionary<string, int[]> SplitArray(int[] input)
        {
            if(input.Length ==2)
            {
                return new Dictionary<string, int[]> { 
                    { "left", new int[] { input[0] } },
                    { "right", new int[] { input[1] } } };
            }
            else
            {
                int[] left = new int[input.Length / 2];
                int[] right = new int[input.Length - left.Length];
                int rightIndex = 0;
                for(int i=0;i<input.Length;i++)
                {
                    if (i < input.Length / 2)
                        left[i] = input[i];
                    else
                    {
                        right[rightIndex] = input[i];
                        rightIndex++;
                    }   
                }
                return new Dictionary<string, int[]>
                {
                    {"left", left },
                    {"right", right }
                };
            }
        }
    }
}
