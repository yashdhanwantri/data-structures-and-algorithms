using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureAndAlgorithms.Searching
{
    class BinarySearch
    {
        public static bool FindElement(int numberToSearch, int[] from)
        {
            if (from.Length == 1 && numberToSearch != from[0])
                return false;
            if (from[from.Length / 2] == numberToSearch)
                return true;
            else if (from[from.Length / 2] > numberToSearch)
            {
                int[] leftArray = new int[from.Length / 2];
                for (int i = 0; i < from.Length / 2; i++)
                    leftArray[i] = from[i];
                return FindElement(numberToSearch, leftArray);
            }
            else if (from[from.Length / 2] < numberToSearch)
            {
                int[] rightArray = new int[from.Length - (from.Length / 2)];
                int arrayCounter = 0;
                for (int i = from.Length / 2; i < from.Length; i++)
                {
                    rightArray[arrayCounter] = from[i];
                    arrayCounter++;
                }
                return FindElement(numberToSearch, rightArray);
            }
            return false;
        }
    }
}
