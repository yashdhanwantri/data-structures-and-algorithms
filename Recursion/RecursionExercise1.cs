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

        public static int FibonacciWithoutRecursion(int number)
        {
            if (number == 0 || number == 1)
                return number;
            int firstNumber = 0;
            int secondNumber = 1;
            int result = 0;
            Console.Write($"{firstNumber} {secondNumber}");
            for(int i=2;i<=number;i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
                Console.Write($" {result}");
            }
            Console.WriteLine();
            return result;
        }
        
        public static int Fibonacci(int number)
        {
            if (number < 2)
                return number;
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        public static string ReverseString(string input)
        {
            if (input.Length == 1)
                return input;
            return ReverseString(input[input.Length - 1].ToString()) + ReverseString(input.Substring(0, input.Length - 1));
        }

    }
}
