using System;

namespace Practical_3
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

        static int[] GetMinMaxElement(int[] arr)
        {
            int max = 0;
            int min = int.MaxValue;
            foreach (int item in arr)
            {
                if (item > max) max = item;
                else if (item < min) min = item;
            }

            return new int[] { min, max };
        }

        static void Main(string[] args)
        {
            int[] arr = BuildArray();
            
            int[] resultArr = GetMinMaxElement(arr);

            Console.WriteLine($"The minimum number in the array is {resultArr[0]}");
            Console.WriteLine($"The maximum number in the array is {resultArr[1]}");
        }
    }
}
