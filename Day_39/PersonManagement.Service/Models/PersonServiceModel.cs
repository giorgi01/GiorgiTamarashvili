using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagement.Service.Models
{
    public class PersonServiceModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonIdentifier { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }
        public string CreditCard { get; set; }
        public string Email { get; set; }
        public string LinkedinProfile { get; set; }
        public string Phone { get; set; }
        public CityServiceModel City { get; set; }
    }
}
