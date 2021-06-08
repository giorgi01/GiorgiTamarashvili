using System;
using System.Text;

namespace Practical_1
{
    public class MatrixMathOperation : IMathOperation<Matrix2D>
    {
        public Matrix2D Add(Matrix2D a, Matrix2D b)
        {
            Matrix2D matrix2D = new Matrix2D();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix2D[i, j] = a[i, j] + b[i, j];
                }
            }
            return matrix2D;
        }

        public Matrix2D Multiply(Matrix2D a, Matrix2D b)
        {
            Matrix2D matrix2D = new Matrix2D();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix2D[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        matrix2D[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return matrix2D;
        }

        public Matrix2D Substract(Matrix2D a, Matrix2D b)
        {
            Matrix2D matrix2D = new Matrix2D();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix2D[i, j] = a[i, j] - b[i, j];
                }
            }
            return matrix2D;
        }
    }
}
