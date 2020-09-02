using System;
using System.Collections.Generic;
using System.Linq; 


namespace Linq
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Address
    {
        public int customerId { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();



            List<Address> addresses = new List<Address>();



            customers.Add(new Customer() { id = 1, name = "Shiv" });
            customers.Add(new Customer() { id = 2, name = "Raju" });
            customers.Add(new Customer() { id = 3, name = "Guru" });
            customers.Add(new Customer() { id = 4, name = "test" });



            addresses.Add(new Address()
            {
                customerId = 1,
                street1 = "Mumbai",
                street2 = "mulund"
            });
            addresses.Add(new Address()
            {
                customerId = 2,
                street1 = "Mumbai",
                street2 = "vashi"
            });




            // LINQ pad
            // List<Customer> custs = (from temp in customers
            //  where temp.name == "Shiv"
            //select temp).ToList<Customer>();
            // Customer x = custs[0];


            var q = (from cust in customers
                     join addr in addresses
                     on cust.id equals addr.customerId

                     select new
                     {
                         ID = cust.id,
                         Name = cust.name,
                         Address = addr.street1,
                     }).ToList();



            var r = (from cust in customers
                     join addr in addresses
                     on cust.id equals addr.customerId
                     into data
                     from addr in data.DefaultIfEmpty()


                     select new
                     {
                         ID = cust.id,
                         Name = cust.name,
                         street1 = addr != null? addr.street1 : "null",
                     }).ToList();



            foreach (var item in q)
            {
                Console.WriteLine("1st Query");
                Console.WriteLine(item.ID +" " + " " + item.Name + " " + item.Address);
               
            }


            
           


            foreach (var item in r)
            {
                Console.WriteLine("2nd Query");
                Console.WriteLine(item.ID + " " + " " + item.Name + " " + item.street1);
            }

            Console.Read();


            // Language Integrated Query









        }
    }

}

