using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Customer()
        {
        }
    }
}
