using System;

namespace Practical_1
{
    class Program
    {
        static Matrix2D BuildMatrix2D()
        {
            Matrix2D matrix = new Matrix2D();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            Matrix2D matrix1 = BuildMatrix2D();
            Matrix2D matrix2 = BuildMatrix2D();
            Console.WriteLine((matrix1 - matrix2).ToString());
            Console.WriteLine((matrix1 + matrix2).ToString());
            Console.WriteLine((-matrix1).ToString());
            Console.WriteLine((matrix1 * matrix2).ToString());
            Console.WriteLine((matrix1 * 3).ToString());
            Console.WriteLine(matrix1.Equals(matrix2));
        }
    }
}
