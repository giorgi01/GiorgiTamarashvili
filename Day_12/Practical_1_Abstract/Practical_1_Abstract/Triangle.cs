using System;

namespace Practical_1_Abstract
{
    public class Triangle : Shape
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

        public override double Perimeter()
        {
            return SideLength(A, B) + SideLength(B, C) + SideLength(C, A);
        }

        public override double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            double sideA = SideLength(A, B);
            double sideB = SideLength(B, C);
            double sideC = SideLength(C, A);

            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }
    }
}