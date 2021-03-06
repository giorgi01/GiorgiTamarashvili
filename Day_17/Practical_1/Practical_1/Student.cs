using System;

namespace Practical_1
{
    public class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalID { get; set; }
        public Student(string firstName, string lastName, string personalID)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalID = personalID;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public int CompareTo(object obj)
        {
            return LastName.CompareTo(((Student)obj).LastName);
        }
    }
}