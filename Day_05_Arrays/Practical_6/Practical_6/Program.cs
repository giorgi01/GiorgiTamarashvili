using System;

namespace Practical_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size: ");
            int rowSize = int.Parse(Console.ReadLine());

            Console.Write("Enter array column size: ");
            int columnSize = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[rowSize, columnSize];
            int[,] secondArray = new int[rowSize, columnSize];


            Console.WriteLine("Fill first matrix");

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Fill second matrix");

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    secondArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Here is sum of two matrices");

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write(firstArray[i, j] + secondArray[i, j]);
                    if (j != columnSize - 1) Console.Write(", ");
                }
                Console.Write("\n");
            }

        }
    }
}
