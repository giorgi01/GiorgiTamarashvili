using System;

namespace Practical_7
{
    class Program
    {
        static int[,] Build2DMatrix()
        {
            Console.Write("Enter array row size: ");
            int rowSize = int.Parse(Console.ReadLine());

            Console.Write("Enter array column size: ");
            int columnSize = int.Parse(Console.ReadLine());

            int[,] arr2D = new int[rowSize, columnSize];

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    arr2D[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return arr2D;
        }

        static int[,] Sum2DMatrices(int[,] a, int[,] b)
        {

            int rowSize = a.GetLength(0);
            int columnSize = a.GetLength(1);

            int[,] resultMatrix = new int[rowSize, columnSize];

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    resultMatrix[i, j] = a[i, j] + b[i, j];
                }
            }

            return resultMatrix;
        }

        static void Print2DMatrix(int[,] matrix)
        {
            int rowSize = matrix.GetLength(0);
            int columnSize = matrix.GetLength(1);

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j != columnSize - 1) Console.Write(", ");
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            int[,] firstArray = Build2DMatrix();
            int[,] secondArray = Build2DMatrix();
            int[,] resultMatrix = Sum2DMatrices(firstArray, secondArray);

            Print2DMatrix(resultMatrix);
        }
    }
}
