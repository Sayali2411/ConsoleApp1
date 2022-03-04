using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class customer
    {
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Distributor
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
    class LinqBasicOperations
    {
        static void Main()
        {
            #region Step 1. DataSource.

            List<customer> customers = new List<customer>
            {
                new customer { Name = "James", City = "London" },
                new customer { Name = "Ashwin", City = "Bristol" },
                new customer { Name = "Bond", City = "London" },
                new customer { Name = "Southee", City = "Bristol" },
                new customer { Name = "Mike", City = "Birmingham" },
         };
            List<Distributor> distributors = new List<Distributor>
            {
                new Distributor { Name = "ABC", City = "London" },
                new Distributor { Name = "ABB", City = "Bristol" },
                new Distributor { Name = "ANN", City = "Birmingham" },
            };
            #endregion

            #region step 2. Get London James Customers and step3 - Display London James Customer
            var QueryLondonNameCustomers = from cust in customers
                                           where cust.City == "London" && cust.Name == "James"
                                           select cust.Name;

            //3. Query execution.
            Console.WriteLine("======================");
            Console.WriteLine("Displaying London and customer name as James:");
            foreach (string name in QueryLondonNameCustomers)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("======================");
            #endregion

            #region step2 - Get Ordered Customers by name and step 3 - Display ordered Customers
            var orderCustomers = from cust in customers
                                 orderby cust.Name ascending
                                 select cust.Name;

            //3. Query execution.
            Console.WriteLine("\n=============================");
            Console.WriteLine("Displaying Ordered Customer Names");
            foreach (string name in orderCustomers)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n=============================");
            #endregion

            #region step2 - group customers by cities and step 3 - group customer by cities
            var groupCustomers = from cust in customers
                                 group cust by cust.City;

            //3.Query execution

            Console.WriteLine("\n======================");
            Console.WriteLine("Displaying grouped Customer City:");
            foreach (var groupList in groupCustomers.ToList())
            {
                foreach (var customer in groupList)
                {
                    Console.WriteLine(customer.City);
                }
            }
            Console.WriteLine("======================");
            #endregion

            #region step2 - group customers by city and step 3 - group Joined customer 
            var innerJoinQuery = from cust in customers
                                 join dist in distributors on cust.City
                                 equals dist.City
                                 select new
                                 {
                                     customerName = cust.Name,
                                     DistributorName = dist.Name
                                 };

            //3.Query execution

            Console.WriteLine("\n======================");
            Console.WriteLine("Displaying Joined Results:");
            foreach (var c in innerJoinQuery)
            {
                Console.WriteLine("customer Name:{0} and Distributor Name: {1}", c.customerName, c.DistributorName);
            }
            Console.WriteLine("======================");
            #endregion
        }
    }
}


        
    
    
   