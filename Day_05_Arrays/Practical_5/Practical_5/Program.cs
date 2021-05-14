using System;

namespace Practical_5
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

            for (int i = 0; i < arrSize; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arrSize; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique) Console.WriteLine(arr[i]);
            }
        }
    }
}
