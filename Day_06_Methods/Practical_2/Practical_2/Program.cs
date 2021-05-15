using System;

namespace Practical_2
{
    class Program
    {
        static void GetElementNumbersSum(int[] arr, int index)
        {
            int element = arr[index];
            int sum = 0;

            while (element != 0)
            {
                sum += element % 10;
                element /= 10;
            }

            Console.WriteLine($"The sum of the digits of a number at {index} is {sum}");
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 123, 15, 13, 23, 98 };
            GetElementNumbersSum(arr, 2);
            GetElementNumbersSum(arr, 4);
        }
    }
}
