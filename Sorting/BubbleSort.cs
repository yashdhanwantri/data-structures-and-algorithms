using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Sorting
{
    public class BubbleSort
    {
        public static int[] Sort(int[] input)
        {
            for(int i= 0;i<input.Length-1; i++)
            {
                for(int j=i; j<input.Length;j++)
                {
                    if(input[j]<input[i])
                    {
                        var temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
    }
}
