using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    public interface IMathOperation<T>
    {
        T Add(T a, T b);
        T Substract(T a, T b);
        T Multiply(T a, T b);
    }
}
