using System;

namespace Practical_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size: ");
            int rowSize = int.Parse(Console.ReadLine());

            Console.Write("Enter array column size: ");
            int columnSize = int.Parse(Console.ReadLine());

            int[,] arr2d = new int[rowSize, columnSize];

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    arr2d[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Here is matrix view of multidimensional array");

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write(arr2d[i, j]);
                    if (j != columnSize - 1) Console.Write(", ");
                }
                Console.Write("\n");
            }
        }
    }
}
