using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(23);
            list.Add("Mayura");
            list.Add(34.56);
            list.Add(34.56);
            list.Add(34.56);
            list.Add(34.56);
            WriteLine($"Capacity of an ArrayList is {list.Capacity}");
            WriteLine($"Count of An ArrayList is {list.Count}");
            ArrayList list1 = new ArrayList();
            list1.Add("Mango");
            list1.Add("grapes");
            list1.Add("Orange");
            list1.AddRange(list);
            foreach(var i in list1)
            {
                WriteLine($"{i}");
            }

            list.Contains("Mayura");
          

            ArrayList list2 =(ArrayList)list1.Clone();
            WriteLine($"Two Objects equal { list1.Equals(list2)}");
            WriteLine($"HAsh code is {list.GetHashCode()}");
            WriteLine($"HAsh code is {list1.GetHashCode()}");
            Console.WriteLine("Hello World!");
        }
    }
}


