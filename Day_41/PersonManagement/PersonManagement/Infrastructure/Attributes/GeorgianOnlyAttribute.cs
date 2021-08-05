using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagement.Infrastructure.Attributes
{
    public class GeorgianOnlyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var str = value as string;

            return string.IsNullOrWhiteSpace(str) || str.All(IsGeorgianOnly);
        }

        private bool IsGeorgianOnly(char c)
        {
            var charCode = (int)c;

            return charCode >= 'ა' && charCode <= 'ჰ';
        }
    }
}
