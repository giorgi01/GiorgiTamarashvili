using System;

namespace Midterm_Practical_2
{
    class Program
    {
        static int[] BuildArray()
        {
            Console.Write("Please enter array size: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Please enter an integer for element at index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static void ShiftArray(int[] arr, int num, bool reverse)
        {
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            if (reverse)
            {
                for (int i = 0; i < num; i++)
                {
                    int j;
                    int tmp = arr[0];
                    for (j = 0; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = tmp;
                }
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    int tmp = arr[arr.Length - 1];

                    for (int j = arr.Length-1; j > 0; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[0] = tmp;
                }
            }
            Console.Write("\n");
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.Write("\n");

        }

        static void Main(string[] args)
        {
            int[] arr = BuildArray();
            ShiftArray(arr, 1, false);
            ShiftArray(arr, 1, true);
            ShiftArray(arr, 1, false);
        }
    }
}