using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    public class Order
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CustomerId { get; set; }
    }
}
