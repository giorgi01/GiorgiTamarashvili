using System;
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