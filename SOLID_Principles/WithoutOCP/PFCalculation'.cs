using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutOCP
{
    internal class PFCalculation
    {
        public double CalculatePF(double salary,string status)
        {
            double Pf=0.0;
            if(status=="Permanent")
            {
                Pf = salary * 0.8;
            }

            else if(status== "Probabtion")
            {
                Pf = salary * 0.6;
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }
            return Pf;
        }
    }
}
