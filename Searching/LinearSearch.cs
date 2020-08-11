using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Searching
{
    class LinearSearch
    {
        public static bool FindElement(int numberToSearch, int[] from)
        {
            foreach(var item in from)
            {
                if (numberToSearch == item)
                    return true;
            }
            return false;
        }
    }
}
