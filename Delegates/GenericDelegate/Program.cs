using System;

namespace GenericDelegate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, double, double> func = new Func<int, int, double, double>(Demo.AddNumber);
            double result = func(1, 3, 4.56);
            Console.WriteLine($"Addition is {result}");
            Action<int, int, double> action = new Action<int, int, double>(Demo.AddNumber1);
            action(1, 2, 3.5);
            Predicate<string> predicate = new Predicate<string>(Demo.checkString);
            bool status = predicate("Mayura");
            Console.WriteLine(status);
            Console.WriteLine("*************Shortcut************************");
            Func<int, float, double> add = (a, b) => a + b;
            Console.WriteLine($"Addition is {add(2,4.3f)}");
            Predicate<string> predicate1 = (name) => name.Length > 5;
            Console.WriteLine($"Lenght of string is greater than 5{predicate1("Mayura")}");
            Action<int, int, double> action1 = (a, b,c) => Console.WriteLine(a + b+c );
            action(1, 2, 3.5);
            Console.WriteLine("Hello World!");
        }
    }
}

