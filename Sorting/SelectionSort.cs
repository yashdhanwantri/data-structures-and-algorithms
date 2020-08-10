using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Sorting
{
    class SelectionSort
    {
        public static  int[] Sort(int[] input)
        {
            for(int i=0;i<input.Length-1;i++)
            {
                int smallestValue = int.MaxValue;
                int smallestValueIndex = 0;
                for(int j=i; j<input.Length;j++)
                {
                    if(input[j]< smallestValue)
                    {
                        smallestValueIndex = j;
                        smallestValue = input[j];
                    }
                }
                int temp = input[i];
                input[i] = input[smallestValueIndex];
                input[smallestValueIndex] = temp;
            }
            return input;
        }
    }
}
