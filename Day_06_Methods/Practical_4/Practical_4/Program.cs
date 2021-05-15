using System;

namespace Practical_4
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

        static double GetArrayAvg(int[] arr)
        {
            int sum = 0;
            int itemsCount = 0;

            foreach (int item in arr)
            {
                sum += item;
                itemsCount += 1;
            }

            return (double)sum / itemsCount;
        }

        static void Main(string[] args)
        {
            int[] arr = BuildArray();
            double arrAvg = GetArrayAvg(arr);

            Console.WriteLine($"Arithmetic average of array is {arrAvg}");
        }
    }
}
