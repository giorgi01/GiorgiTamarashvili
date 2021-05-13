using System;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arrSize = int.Parse(Console.ReadLine());

            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < arrSize; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Sum of array elements is {sum}");
        }
    }
}
