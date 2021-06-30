using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practical_1
{
    public static class DbManager
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (StreamReader sw = new StreamReader("Customers.txt"))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    var splittedLine = line.Split('|');
                    customers.Add(new Customer()
                    {
                        Id = int.Parse(splittedLine[0]),
                        Name = splittedLine[1]
                    });
                }
            }
            return customers;
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            using (StreamReader sw = new StreamReader("Orders.txt"))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    var splittedLine = line.Split('|');
                    orders.Add(new Order()
                    {
                        Id = int.Parse(splittedLine[0]),
                        Date = splittedLine[1],
                        ProductName = splittedLine[2],
                        Price = double.Parse(splittedLine[3]),
                        CustomerId = int.Parse(splittedLine[4])
                    });
                }
            }
            return orders;
        }
    }
}
