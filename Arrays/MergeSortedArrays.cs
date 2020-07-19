using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Arrays
{
    class MergeSortedArrays
    {
        public int[] MergeArrays(int[] input1, int[] input2)
        {
            int[] result = new int[input1.Length + input2.Length];
            int input1Counter = 0;
            int input2Counter = 0;
            int resultCounter = 0;
            int length = input1.Length > input2.Length ? input1.Length : input2.Length;
            bool arrayMerged = false;
            while(!arrayMerged)
            {
                if(input1[input1Counter] < input2[input2Counter])
                {
                    result[resultCounter] = input1[input1Counter];
                }
                else
                {
                    result[resultCounter] = input2[input2Counter];
                }
            }
            return result;
        }
    }
}
