using System;

namespace Practical_4
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

            int product = 1;

            for (int i = 0; i < arrSize; i++)
            {
                product *= arr[i];
            }

            Console.WriteLine($"Product of array elements is {product}");
        }
    }
}
