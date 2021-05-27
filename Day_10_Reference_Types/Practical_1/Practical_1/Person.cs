using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PersonalId { get; set; }
        public Home Home { get; set; }

        public Person(string name, int age, string personalId)
        {
            Name = name;
            Age = age;
            PersonalId = personalId;
        }
    }
}
