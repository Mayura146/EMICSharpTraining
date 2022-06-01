using System;
using WithouDIP;

namespace WithDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reminder r = new Reminder();
            r.start();
            Console.WriteLine("Hello World!");
        }
    }
}
