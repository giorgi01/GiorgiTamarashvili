using Day_39.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day_39.Infrastructure.Attributes
{
    public class GeorgianOnlyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var str = value as string;

            if (string.IsNullOrWhiteSpace(str) || str.All(IsGeorgianOnly))
                return true;
            else
                throw new LanguageFormatException("Text language is not Georgian");
        }

        private bool IsGeorgianOnly(char c)
        {
            var charCode = (int)c;

            return charCode >= 'ა' && charCode <= 'ჰ';
        }
    }
}
