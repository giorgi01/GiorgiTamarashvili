using System;

namespace Practical_2
{
    public class IncorrectUserExepction : Exception
    { 

        public IncorrectUserExepction(string message) : base(message)
        {
        }

        public IncorrectUserExepction(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}