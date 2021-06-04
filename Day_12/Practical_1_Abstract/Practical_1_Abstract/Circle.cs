using System;

namespace Practical_1_Abstract
{
    public class Circle : Shape
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

        public override double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}