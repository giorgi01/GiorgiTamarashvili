using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    public class Matrix2D
    {
        private double[,] _matrix = new double[2, 2];
        public double this[int i, int j]
        {
            get => _matrix[i, j];
            set => _matrix[i, j] = value;
        }
        public Matrix2D(double a, double b, double c, double d)
        {
            _matrix[0, 0] = a;
            _matrix[0, 1] = b;
            _matrix[1, 0] = c;
            _matrix[1, 1] = d;
        }

        public Matrix2D()
        {
        }

        public static implicit operator double(Matrix2D v)
        {
            double sum = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum += v[i, j];
                }
            }
            return sum;
        }

        public static Matrix2D operator +(Matrix2D a, Matrix2D b)
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

        public static Matrix2D operator -(Matrix2D a, Matrix2D b)
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

        public static Matrix2D operator *(Matrix2D a, Matrix2D b)
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

        public static Matrix2D operator *(Matrix2D a, double b)
        {
            Matrix2D matrix2D = new Matrix2D();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix2D[i, j] = a[i,j] * b;
                }
            }
            return matrix2D;
        }

        public static Matrix2D operator -(Matrix2D a)
        {
            Matrix2D matrix2D = new Matrix2D();
            double adj = 1 / (a[0, 0] * a[1, 1] - a[1, 0] * a[0, 1]);

            Matrix2D b = new Matrix2D(a[0, 0], a[0, 1], a[1, 0], a[1, 1]); // copy of previous matrix

            double tmp = b[0, 0];
            b[0, 0] = b[1, 1];
            b[1, 1] = tmp;
            b[0, 1] = -b[0, 1];
            b[1, 0] = -b[1, 0];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix2D[i, j] = a[i, j] * adj;
                }
            }
            return matrix2D;
        }

        public override bool Equals(object obj)
        {
            Matrix2D matrix2D = (Matrix2D)obj;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (this[i, j] != matrix2D[i, j])
                        return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sb.Append(this[i, j]);
                    sb.Append(" ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
