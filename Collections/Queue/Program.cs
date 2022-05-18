using System;
using  System.Collections.Generic;

namespace Queue1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Jan");
            queue.Enqueue("Feb");
            queue.Enqueue("March");
            foreach(var i in queue)
            {
               Console.WriteLine(i);
            }

            string[] array = new string[5];
            array[0] = "May";
            array[1] = "June";
            array[2] = "July";
            queue.CopyTo(array, 1);
            Console.WriteLine("Array Elements are");
            foreach(var i in array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Peek {queue.Peek()}");
            queue.Dequeue();
            Console.WriteLine("Hello World!");
        }
    }
}
