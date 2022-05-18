using System;
using System.Collections.Generic;

namespace Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("1");
            hashset.Add("2");
            hashset.Add("3");
            hashset.Add("Jan");
            hashset.Add("Feb");
            hashset.Add("March");
            

            HashSet<string> vs = new HashSet<string>();
            vs.Add("Jan");
            vs.Add("Feb");
            vs.Add("March");
            vs.Add("April");
            vs.Add("45");
            vs.Add("456");
            hashset.ExceptWith(vs);
            Console.WriteLine("Except with");
            foreach (var i in hashset)
            {
                Console.WriteLine(i);
            }
            // Union
            hashset.UnionWith(vs);
            Console.WriteLine("Union with");
            foreach( var i in hashset )
            {
                Console.WriteLine(i);   
            }

            // Intersect
            hashset.IntersectWith(vs);
            Console.WriteLine("Intersect with");
            foreach (var i in hashset)
            {
                Console.WriteLine(i);
            }
            //ExceptWith

           
            HashSet<Customer> customer = new HashSet<Customer>
            {

                new Customer{Id = 1, Name ="Mayura",Location = "Bangalore"},
                   new Customer{Id = 2, Name ="Mayura",Location = "Bangalore"},
                      new Customer{Id = 3, Name ="Mayura",Location = "Bangalore"},
                       new Customer{Id = 1, Name ="Mayura",Location = "Bangalore"},
            };

            //customer.Add(new Customer { Id = 5, Name = "Sam", Location = "Pune" });
            //foreach (var customer1 in customer)
            //{
            //    Console.WriteLine(customer1.Id);
            //    Console.WriteLine(customer1.Location);
            //    Console.WriteLine(customer1.Name);
            //}

          
            Console.WriteLine("Hello World!");
        }
    }
}
