using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Sorting
{
    public class InsertionSort
    {
        public static int[] Sort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                var temp = input[i];

                //When Item is smaller than the first element in an array i.e. Inserting at first index.
                if(input[i]< input[0])
                {
                    for(int j = i;j>0;j--)
                    {
                        input[j] = input[j - 1];
                    }
                    input[0] = temp;
                }

                //When Item needs to be inserted in between of 2 items
                else
                {
                    for(int j=1;j<i;j++)
                    {
                        if (input[i] <= input[j] && input[i] > input[j - 1])
                        {
                            for (int k = i; k > j; k--)
                            {
                                input[k] = input[k - 1];
                            }
                            input[j] = temp;
                        }
                    }
                }
                
            }
            return input;
        }
    }
}
