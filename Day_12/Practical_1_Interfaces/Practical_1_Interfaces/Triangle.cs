using System;

namespace Practical_1_Interfaces
{
    public class Triangle : IShapeable
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return SideLength(A, B) + SideLength(B, C) + SideLength(C, A);
        }

        public double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            double sideA = SideLength(A, B);
            double sideB = SideLength(B, C);
            double sideC = SideLength(C, A);

            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }
        private double SideLength(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
    }
}