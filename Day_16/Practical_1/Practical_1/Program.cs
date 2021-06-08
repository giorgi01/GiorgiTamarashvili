using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntMathOperation intMath = new IntMathOperation();
            Console.WriteLine(intMath.Add(3,2));
            Console.WriteLine(intMath.Multiply(3,2));
            Console.WriteLine(intMath.Substract(3,2));

            MatrixMathOperation matrixMath = new MatrixMathOperation();
            Matrix2D matrix1 = new Matrix2D(1, 2, 3, 4);
            Matrix2D matrix2 = new Matrix2D(1, 2, 3, 4);
            Console.WriteLine();
            Console.WriteLine(matrixMath.Add(matrix1, matrix2).ToString());
            Console.WriteLine(matrixMath.Multiply(matrix1, matrix2).ToString());
            Console.WriteLine(matrixMath.Substract(matrix1, matrix2).ToString());

            VectorMathOperation vectorMath = new VectorMathOperation();
            Vector vect1 = new Vector(3, 2);
            Vector vect2 = new Vector(3, 2);
            Console.WriteLine(vectorMath.Add(vect1, vect2).ToString());
            Console.WriteLine(vectorMath.Multiply(vect1, vect2).ToString());
            Console.WriteLine(vectorMath.Substract(vect1, vect2).ToString());
        }
    }
}