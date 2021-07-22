using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_2
{
    class SecondCorrectAnswerException : Exception
    {
        public SecondCorrectAnswerException(string message) : base(message)
        {
        }
    }
}
