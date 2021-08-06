using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_39.Infrastructure.Exceptions
{
    public class AgeIsNotValidException : Exception
    {
        public string Code = "BadRequest";

        public AgeIsNotValidException(string message) : base(message)
        {

        }
    }

}