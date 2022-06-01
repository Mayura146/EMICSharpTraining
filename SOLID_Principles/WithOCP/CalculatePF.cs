using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithOCP
{
    public abstract class CalculatePF
    {
        public abstract void PFCalculation(double salary, string status);
        public double totalPf = 0;


    }

    public class Permanent:CalculatePF
    {
        public override void PFCalculation(double salary, string status)
        {
            totalPf = salary * 0.8;
            Console.WriteLine(totalPf);
        }
    }

    public class Probabtion:CalculatePF
    {
        public override void PFCalculation(double salary, string status)
        {
            totalPf = salary * 0.6;
            Console.WriteLine(totalPf);
        }
    }

    public class Contract:CalculatePF
    {
        public override void PFCalculation(double salary, string status)
        {
            totalPf = salary * 0.3;
            Console.WriteLine(totalPf);
        }
    }
}
