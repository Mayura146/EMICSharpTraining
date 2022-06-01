using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutISP
{
    internal interface IEmployee
    {
        void paidLeaves();
        void SickLeaves();
        void publicHoliday();
    }

    class PEmployee:IEmployee
    {
        public void paidLeaves()
        {

        }

        public void publicHoliday()
        {
            throw new NotImplementedException();
        }

        public void SickLeaves()
        {
            throw new NotImplementedException();
        }
    }

    class CEmployee : IEmployee
    {
        public void paidLeaves()
        {
            throw new NotImplementedException();
        }

        public void publicHoliday()
        {
            throw new NotImplementedException();
        }

        public void SickLeaves()
        {
            throw new NotImplementedException();
        }
    }

    public class EProbabtion : IEmployee
    {
        public void paidLeaves()
        {
            throw new NotImplementedException();
        }

        public void publicHoliday()
        {
            throw new NotImplementedException();
        }

        public void SickLeaves()
        {
            throw new NotImplementedException();
        }
    }
}
