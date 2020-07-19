using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Arrays
{
    class MergeSortedArrays
    {
        public static int[] MergeArrays(int[] inputA, int[] inputB)
        {
            int[] result = new int[inputA.Length + inputB.Length];
            if (inputA.Length == 0)
                return inputB;
            else if (inputB.Length == 0)
                return inputA;
            int counterA = 0;
            int counterB = 0;
            int resultCounter = 0;
            while(resultCounter!= result.Length)
            {
                if(counterA<inputA.Length &&  (counterB == inputB.Length || inputA[counterA]<inputB[counterB]))
                {
                    result[resultCounter] = inputA[counterA];
                    counterA++;
                }
                else
                {
                    result[resultCounter] = inputB[counterB];
                    counterB++;
                }
                resultCounter++;
            }
            return result;
        }
    }
}
