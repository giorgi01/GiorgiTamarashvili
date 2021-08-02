using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Day_39.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day_39.Models.DTO
{
    public class PersonDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [GeorgianOnly]
        public string FirstName { get; set; }

        [Required]
        [GeorgianOnly]
        [MinLength(4)]
        public string LastName { get; set; }

        [StringLength(11, ErrorMessage = "{0} value must be between {2} and {1}", MinimumLength = 9)]
        public string Identifier { get; set; }
        
        public bool Gender { get; set; }

        [Required]
        [AgeRestricted]
        public DateTime BirthDate { get; set; }
        
        [CreditCard]
        public string CreditCard { get; set; }
        
        [Range(0, 150)]
        public int Age { get; set; }

        [ValidateNever]
        public string Description { get; set; }

        //[RegularExpression("(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$)")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Phone]
        public string Phone { get; set; }

        [Url]
        public string LinkedinProfile { get; set; }
        
        public string City { get; set; }
    }
}
