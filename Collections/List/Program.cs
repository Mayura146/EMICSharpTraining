using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
         SortedSet<string> set=new SortedSet<string>();
            set.Add("Jan");
            set.Add("Feb");
          //  set.Add("April");
            set.Add("March");
            set.Add("April");
            set.Add("May");
            set.Add("June");
            Console.WriteLine("Set value is");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Type"+set.GetType());
            SortedSet<string> set2 = set.GetViewBetween( "April","Jan");
            Console.WriteLine("Get View");
            foreach(var i in set2)
            {
                Console.WriteLine("" + i);
            }
            


            Console.WriteLine("Hello World!");
        }
    }
}
