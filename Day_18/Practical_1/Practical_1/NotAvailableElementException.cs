using System;

namespace Practical_1
{
    internal class NotAvailableElementException : Exception
    {
        public NotAvailableElementException(string text) : base(string.Format("Problem Detected: {0}", text))
        {

        }
    }
}