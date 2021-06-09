using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    public class IntMathOperation : IMathOperation<int>
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
