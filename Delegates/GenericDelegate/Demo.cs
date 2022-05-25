using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    internal class Demo
    {
        public static double AddNumber(int a,int b,double c)
        {
            return a + b + c;
        }

        public static void AddNumber1(int a,int b,double c)
        {
            Console.WriteLine(a + b + c);
        }

        public static bool checkString(string name)
        {
            if(name.Length>5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
