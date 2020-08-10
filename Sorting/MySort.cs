using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Sorting
{
    public class MySort
    {
        public static int[] Sort(int[] input)
        {
            for(int i=0;i<input.Length;i++)
            {
                for(int j=i;j<input.Length-1; j++)
                {
                    if(input[i]>input[j])
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
