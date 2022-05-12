using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic
{
    public static class Extension
    {
        static string s1 = "Mayura";
        
        public static void Message(this Demo d,int a)
        {
            Console.WriteLine(a);
            
            Console.WriteLine("Message Function of Demo class ");
        }
        public static int Factorial(this Int32 x)
        {
            if(x==1 ||x==2)
            {
                return x;
            }

            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
