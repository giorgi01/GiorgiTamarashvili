using System;

namespace Practical_1_Abstract
{
    public abstract class Shape
    {
        public abstract double Perimeter();
        public abstract double Area();
        protected double SideLength(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
    }
}