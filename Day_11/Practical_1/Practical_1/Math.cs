using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    public static class Math
    {
        public static double Pow(double num, double degree, out Status status)
        {
            if (degree < 0)
            {
                status = Status.PowMustBeaPositiveOrZero;
                return (double)Status.PowMustBeaPositiveOrZero;
            }
            else if (degree == 0)
            {
                status = Status.Success;
                return 1;
            }
            else
            {
                double result = num;
                for (int i = 0; i < degree - 1; i++)
                {
                    result *= num;
                }

                status = Status.Success;
                return result;
            }
        }

        public static double Min(double a, double b, out Status status)
        {
            if (a < b)
            {
                status = Status.Success;
                return a;
            }
            else if (a > b)
            {
                status = Status.Success;
                return b;
            }
            else
            {
                status = Status.ValuesAreEqual;
                return a;
            }
        }

        public static double Max(double a, double b, out Status status)
        {
            if (a > b)
            {
                status = Status.Success;
                return a;
            }
            else if (a < b)
            {
                status = Status.Success;
                return b;
            }
            else
            {
                status = Status.ValuesAreEqual;
                return a;
            }
        }

    }
}
