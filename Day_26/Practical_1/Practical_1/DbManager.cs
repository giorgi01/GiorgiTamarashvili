using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Practical_1
{
    public static class DbManager
    {
        public static void PrintOrdersPerCustomer()
        {
            var orders = GetOrders();
            var ordersPerCustomer = orders.GroupBy(o => o.CustomerId).Select(g => new { g.Key, Count = g.Count() });
            foreach (var g in ordersPerCustomer)
            {
                Console.WriteLine($"Customer id: {g.Key}, orders count: {g.Count}");
            }
        }

        public static void PrintOrdersSumAmount()
        {
            var orders = GetOrders();
            var ordersPerCustomer = orders.GroupBy(o => o.CustomerId).Select(g => new { g.Key, Sum = g.Sum(o => o.Price) });
            foreach (var g in ordersPerCustomer)
            {
                Console.WriteLine($"Customer id: {g.Key}, orders sum amount: {g.Sum}");
            }
        }

        public static void PrintOrdersMinAmount()
        {
            var orders = GetOrders();
            var ordersPerCustomer = orders.GroupBy(o => o.CustomerId).Select(g => new { g.Key, Min = g.Min(o => o.Price) });
            foreach (var g in ordersPerCustomer)
            {
                Console.WriteLine($"Customer id: {g.Key}, min amount: {g.Min}");
            }
        }

        public static void PrintCustomersMoreThanOneOrder()
        {
            var orders = GetOrders();
            var ordersPerCustomer = orders.GroupBy(o => o.CustomerId).Select(g => new { g.Key, Count = g.Count() });
            var cWithMoreThanOneOrder = ordersPerCustomer.Where(g => g.Count > 1);
            foreach (var g in ordersPerCustomer)
            {
                Console.WriteLine($"Customer id: {g.Key}, orders count: {g.Count}");
            }
        }

        public static void PrintCsWithAvgAmountMoreThanTen() // ვიცი გრძელი სახელია უბრალოდ სხვა ვერ მოვიფიქრე
        {
            var orders = GetOrders();
            var ordersPerCustomer = orders.GroupBy(o => o.CustomerId).Select(g => new { g.Key, Average = g.Average(o => o.Price) });
            var cWithAvgMoreThanTen = ordersPerCustomer.Where(g => g.Average > 10);
            foreach (var g in ordersPerCustomer)
            {
                Console.WriteLine($"Customer id: {g.Key}, avg: {g.Average}");
            }
        }
        private static List<Order> GetOrders()
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
        private static List<Customer> GetCustomers()
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
    }
}
