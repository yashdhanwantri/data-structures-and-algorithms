using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Sorting
{
    public class InsertionSort
    {
        public static int[] Sort(int[] input)
        {
            if (input[1] < input[0])
            {
                var temp = input[0];
                input[0] = input[1];
                input[1] = temp;
            }
            for (int i = 2;i<input.Length-1; i++)
            {
                for(int j =i-1;j>=0;j--)
                {
                    //When item needs to be inserted at first place
                    if(j==0 && input[i]<=input[j])
                    {
                        var temp = input[i];
                        for (int k= i; k>j; k--)
                        {
                            input[k] = input[k - 1];
                        }
                        input[0] = temp;
                    }

                    //When Item needs to be inserted in between of 2 items
                    if (input[i] <= input[j] && input[i] > input[j-1])
                    {
                        var temp = input[i];
                        for (int k = i; k > j; k--)
                        {
                            input[k] = input[k - 1];
                        }
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
    }
}
