using System;
using static System.Console;
namespace Delegates
{

    public class DelegateDemo
    {

        // Step 1 => declaration
        public delegate void TestDelegate();
        public delegate void DemoDelegate(int a);
        public delegate void OutParamterDelegate(out int x);

        public void Method1 ()
        {
            WriteLine("Method 1 executed!!");
        }

        public void Method2()
        {
            WriteLine("Method 2 executed!!");
        }
        public void Method3()
        {
            WriteLine("Method 3 executed!!");
        }

        public void Method4(int a)
        {
            WriteLine($"Value of a is {a}");
        }
        public void Method5(int b)
        {
            WriteLine($"Value of a is {b}");
        }
        public void Method6(out int a)
        {
            a = 56;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            DelegateDemo d = new DelegateDemo();
            // Step 2=> Initialization of delegate
            DelegateDemo.TestDelegate td = new DelegateDemo.TestDelegate(d.Method1);
            td();
            td += d.Method2;
            td+=d.Method3;
            td();
            td -= d.Method1;
            WriteLine("After removing reference of MEthod 1");
            td();
            DelegateDemo.DemoDelegate demoDelegate = new DelegateDemo.DemoDelegate(d.Method4);
            demoDelegate(23);

            WriteLine("Delgate with Out parameter");

            DelegateDemo.OutParamterDelegate ot = new DelegateDemo.OutParamterDelegate(d.Method6);
            int value = 0;
            ot(out value);
            WriteLine($"Out paramter values is { value}");
            Console.WriteLine("Hello World!");
        }
    }
}
