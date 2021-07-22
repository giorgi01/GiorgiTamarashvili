using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
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
                    for (int i = 0; i < arr.Length; i++) // ak albat tmp damatebiti cvladit unda gadagvwyvita
                    {
                        if (i - num < 0)
                            arr[i] = arr[i - num + arr.Length - 1];
                        else
                            arr[i] = arr[i - num];
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i - num < 0)
                            arr[i - num + arr.Length - 1] = arr[i];
                        else
                            arr[i - num] = arr[i];
                    }
                }
                Console.Write("\n");
                foreach (var item in arr)
                {
                    Console.Write(item);
                }
            }

            int[] arr = BuildArray();
            ShiftArray(arr, 2, true);
        }
    }
}
