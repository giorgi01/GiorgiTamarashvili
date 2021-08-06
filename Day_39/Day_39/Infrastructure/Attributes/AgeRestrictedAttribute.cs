using Day_39.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day_39.Infrastructure.Attributes
{
    public class AgeRestrictedAttribute : ValidationAttribute 
    {
        private readonly int _minAge = 18;

        public AgeRestrictedAttribute()
        {

        }

        public AgeRestrictedAttribute(int age)
        {
            _minAge = age;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value is DateTime)
            {
                var dateOfBirth = (DateTime)value;

                var age = (DateTime.Today - dateOfBirth).Days / 365;

                if(age < _minAge)
                {
                    throw new AgeIsNotValidException($"Age is less than {_minAge}");
                }
            }

            return ValidationResult.Success;
        }
    }
}
