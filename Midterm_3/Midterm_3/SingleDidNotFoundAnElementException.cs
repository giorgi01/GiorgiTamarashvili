using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_3
{
    class SingleDidNotFoundAnElementException : Exception
    {
        public SingleDidNotFoundAnElementException(string message = "Single method did not found corresponding element in the list") : base(message)
        {
        }
    }
}
