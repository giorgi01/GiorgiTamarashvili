using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PersonManagement.Domain.POCO
{
    public partial class Person
    {
        [Key]
        [StringLength(20)]
        public string FirstName { get; set; }
        public int Id { get; set; }
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(11)]
        public string PersonIdentifier { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
