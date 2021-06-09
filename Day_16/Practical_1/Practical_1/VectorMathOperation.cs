using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    class VectorMathOperation : IMathOperation<Vector>
    {
        public Vector Add(Vector a, Vector b)
        {
            return new Vector(a.Abscissa + b.Abscissa, a.Ordinate + b.Ordinate);
        }

        public Vector Multiply(Vector a, Vector b)
        {
            return new Vector(a.Abscissa * b.Abscissa, a.Ordinate * b.Ordinate);
        }

        public Vector Substract(Vector a, Vector b)
        {
            return new Vector(a.Abscissa + -b.Abscissa, a.Ordinate + -b.Ordinate);
        }
    }
}
