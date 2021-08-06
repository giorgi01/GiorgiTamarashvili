using PersonManagement.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagement.Models.DTO
{
    public class PersonDTO
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        [GeorgianOnly]
        public string LastName { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "{0} value must be between {2} and {1}", MinimumLength = 9 )]
        public string Identifier { get; set; }
        public bool Gender { get; set; }

        [Required]
        [MinAge(18)]
        public DateTime BirthDate { get; set; }

        [Required]
        [Range(10, 20)]
        public int Age { get; set; }

        public string City { get; set; }
    }
}
