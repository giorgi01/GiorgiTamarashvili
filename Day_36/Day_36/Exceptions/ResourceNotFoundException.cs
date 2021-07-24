using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_36.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public string Code = "NotFound";

        public ResourceNotFoundException(string errorText) : base(errorText)
        {

        }
    }
}
