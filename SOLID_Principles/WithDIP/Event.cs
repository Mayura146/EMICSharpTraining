using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDIP;

namespace WithouDIP
{
    internal class Event:Icalendar
    {
        public DateTime startTime;
        public DateTime endTime;
        public string title;
        public string description;

        public void start()
        {
            Console.WriteLine("Event Started!!!");
        }

       
    }
}
