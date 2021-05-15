using System;

namespace Practical_5
{
    class Program
    {
        static int[] BuildArray()
        {

            Console.Write("Enter array size: ");
            int arrSize = int.Parse(Console.ReadLine());

            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int GetElementFactorial(int[] arr, int el)
        {
            foreach (int item in arr)
            {
                if (item == el) return Factorial(el);
            }
            return -1; // -1 ==> Not found
        }

        static int Factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main(string[] args)
        {
            int[] arr = BuildArray();
            int num = 6;
            int factorial = GetElementFactorial(arr, 6);

            if (factorial == -1)
            {
                Console.WriteLine($"Number {num} was not found in the given array");
            }
            else
            {
                Console.WriteLine($"Factorial of {num} is {factorial}");
            }
        }
    }
}
