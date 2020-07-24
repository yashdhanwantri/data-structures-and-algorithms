using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Arrays
{
    public class MyArrayList
    {
        public static void TestMyArrayList()
        {
            
            ArrayList arr = new ArrayList();
            arr.Add("abc");
            arr.Add(1);
            arr.Add(23);
            arr.Add("End");
            foreach(var element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
