using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace DataStructureAndAlgorithms.Recursion
{
    public class RecursionExercise1
    {
        static int counter = 0;
        public static string Inception()
        {
            Console.WriteLine($"Counter Value: {counter}");
            if (counter > 3)
                return "Done!";
            counter++;
            return Inception();
        }

        public static int FactorialWithoutRecursion(int number)
        {
            int result = 1;
            for (int i = number; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }

        public static int Factorial(int number)
        {
            if (number == 2)
                return 2;
            return number * Factorial(number - 1);
            
        }
    }
}
