using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithouDIP
{
    internal class Calendar
    {
        Event e1;
        Reminder r1;

        public Calendar()
        {
            e1 = new Event();
            r1=new Reminder();
        }

        public void Starte()
        {
            e1.startEvent();
            r1.startReminder();
        }
    }
}
