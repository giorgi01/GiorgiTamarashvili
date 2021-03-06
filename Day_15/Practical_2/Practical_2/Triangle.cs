using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                Console.WriteLine("Not valid triangle");
            }
        }

        public double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public static bool operator ==(Triangle a, Triangle b)
        {
            return a.Area() == b.Area();
        }

        public static bool operator !=(Triangle a, Triangle b)
        {
            return a.Area() != b.Area();
        }

        public static bool operator >(Triangle a, Triangle b)
        {
            return a.Area() > b.Area();
        }

        public static bool operator <(Triangle a, Triangle b)
        {
            return a.Area() < b.Area();
        }

        public static Triangle operator +(Triangle a, Triangle b)
        {
            double area = a.Area() + b.Area();
            double aSide = area * 0.7; // random length
            double height = 2 * area / aSide;
            double hypotenuse = Math.Sqrt(Math.Pow(aSide, 2) + Math.Pow(height, 2));

            return new Triangle(aSide, height, hypotenuse);
        }

        public static explicit operator Triangle(double a)
        {
            return new Triangle(a, a, a);
        }
    }
}
