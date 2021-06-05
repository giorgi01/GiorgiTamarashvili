namespace Practical_1_Abstract
{
    public class Rectangle : Shape
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        public Rectangle(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override double Area()
        {
            return SideLength(A, B) * SideLength(B, C);
        }

        public override double Perimeter()
        {
            return SideLength(A, B) + SideLength(B, C) + SideLength(C, D) + SideLength(D, A);
        }
    }
}