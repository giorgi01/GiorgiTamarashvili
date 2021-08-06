using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_39.Infrastructure.Exceptions
{
    public class LanguageFormatException : Exception
    {
        public string Code { get; } = "BadRequest";
        public LanguageFormatException(string message) : base(message)
        {

        }
    }
}
