using System;

namespace Practical_1_Interfaces
{
    public class Circle : IShapeable
    {
        public Point O { get; set; }
        public Point A { get; set; }
        private double _radius;
        public Circle(Point o, Point a)
        {
            O = o;
            A = a;
            _radius = SideLength(O, A);
        }

        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
        private double SideLength(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
    }
}