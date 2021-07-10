using System;
using System.Collections.Generic;
using System.Text;

namespace second_midterm_Giorgi_Tamarashvili
{
    class SecondCorrectAnswerException : Exception
    {
        public SecondCorrectAnswerException(string message) : base(message)
        {
        }
    }
}
