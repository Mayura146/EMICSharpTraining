using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDIP;

namespace WithouDIP
{
    internal class Calendar:Icalendar
    {
        Icalendar c;
        public Calendar(Icalendar _c)
        {
            c = _c;
        }

        public void start()
        {
            c.start();
        }
    }
}
