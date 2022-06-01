using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IemployeePermanent
    {
        void paidLeaves();
        void SickLeaves();
     
    }

   interface IEmpContract
    {
        void publicHoliday();

    }
    interface IEmployeesProbabtion
    {
      void SickLEave()
       
    }

   public class Permanent:IemployeePermanent,IEmpContract
    {

    }

    public class Contract:IEmpContract
    {

    }
    class Probabtion: IEmployeesProbabtion, IEmpContract
    {

    }
}
