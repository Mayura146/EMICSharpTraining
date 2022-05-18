using System;
using System.Collections.Generic;
namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
           stack.Push(3);
            stack.Push(4);

           Console.WriteLine("PEEK"+ stack.Peek());
           
            Console.WriteLine("POP"+stack.Pop());
            Console.WriteLine("TRY POP"+stack.TryPop(out int a));
            Console.WriteLine(a);
            Console.WriteLine("****");
            foreach( var i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
