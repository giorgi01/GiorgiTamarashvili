using System;

namespace Practical_1
{
    internal class NotAvailableElementException : Exception
    {
        public NotAvailableElementException()
        {
        }

        public NotAvailableElementException(string message) : base(message)
        {
        }

        public NotAvailableElementException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}