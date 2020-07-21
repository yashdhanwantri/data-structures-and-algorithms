using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Challenges
{
    class SecondLargestElementArray
    {
        public static int FindSecondLargestElementArray(int[] input)
        {
            int firstElement = int.MinValue;
            int secondElement = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > firstElement)
                {
                    secondElement = firstElement;
                    firstElement = input[i];
                }
                else if(secondElement < input[i])
                {
                    secondElement = input[i];
                }
            }
            return secondElement;
        }
    }
}
