using System;
using static System.Console;
using System.Collections.Generic;
namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Jan");
            dic.Add(2, "Feb");
            dic.Add(3, "Jan");
            WriteLine("Dicitonary value is");
            foreach(var i in dic)
            {
                WriteLine(i);
            }
            WriteLine("Values");
            foreach(KeyValuePair<int,string> i in dic)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine(dic.ContainsKey(2));
            Console.WriteLine(dic.ContainsValue("Jan"));
            Console.WriteLine("Try GetValue dic"+ dic.TryGetValue(2, out var value));
            Console.WriteLine(value);
            Console.WriteLine("Hello World!");


            Dictionary<int,Employee> emplist=new Dictionary<int, Employee>();
            Employee e1 = new Employee()
            {
                Id = 1,
                Name = "Mayura"
            };
            Employee e2 = new Employee()
            {
                Id = 2,
                Name = "Sam"
            };
            Employee e3 = new Employee()
            {
                Id = 3,
                Name = "John"
            };

            emplist.Add(e1.Id,e1);
            emplist.Add(e2.Id,e2);  
            emplist.Add(e3.Id,e3);
            Console.WriteLine("Values are");
            foreach(var i in emplist)
            {
                Console.WriteLine($"ID is {i.Value.Id}");
                Console.WriteLine(i.Value.Name);
                            }
                
        }
    }
}
