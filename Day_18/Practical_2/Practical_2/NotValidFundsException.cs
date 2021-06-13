using System;

namespace Practical_2
{
    public class NotValidFundsException : Exception
    { 
        public NotValidFundsException(string message) : base(message)
        {
        }

        public NotValidFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}