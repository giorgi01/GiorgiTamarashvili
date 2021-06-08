using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    public class Vector
    {
        public Vector(double a, double o)
        {
            Abscissa = a;
            Ordinate = o;
        }
        public double Abscissa { get; set; }
        public double Ordinate { get; set; }
        public override string ToString()
        {
            return $"x: {Abscissa} y:{Ordinate}";
        }
    }
}