using System.Collections.Generic;

namespace Practical_2
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalID { get; set; }
        public List<IBAN> BankAccounts { get; set; } = new List<IBAN>();
        public User(string firstName, string lastName, string personalID)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalID = personalID;
        }
    }
}