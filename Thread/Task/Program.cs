using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        public static void PrintNumbers()
        {
            Console.WriteLine($"Child Thread: {Thread.CurrentThread.ManagedThreadId} Started");
            for (int i = 0; i <=20;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Child Thread: {Thread.CurrentThread.ManagedThreadId} Completed");
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread :{Thread.CurrentThread?.ManagedThreadId} Started");
            Task task = Task.Run(() =>
            {
                PrintNumbers();
            });
           task.Wait();
            Console.WriteLine($"Main Thread :{Thread.CurrentThread?.ManagedThreadId} Completed");
            Console.WriteLine("Hello World!");
        }
    }
}
