using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Sorting
{
    public class BubbleSort
    {
        public static int[] Sort(int[] input)
        {
            for(int i= 0;i<input.Length; i++)
            {
                for(int j=0; j<input.Length-1;j++)
                {
                    if(input[j]>input[j+1])
                    {
                        var temp = input[j];
                        input[j] = input[j+1];
                        input[j+1] = temp;
                    }
                }
            }
            return input;
        }
    }
}
