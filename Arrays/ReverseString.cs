using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Arrays
{
    public class ReverseString
    {
        public static string Reverse(string input)
        {
            char[] result = new char[input.Length];
            int resultIndex = 0;
            for(int i=input.Length-1; i>=input.Length/2; i--)
            {
                result[resultIndex] = input[i];
                result[i] = input[resultIndex];
                resultIndex++;
            }
            string resultString = new string(result);
            return resultString;
        }
    }
}
