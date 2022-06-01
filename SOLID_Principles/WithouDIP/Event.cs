using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithouDIP
{
    internal class Event
    {
        public DateTime startTime;
        public DateTime endTime;
        public string title;
        public string description;
        public void startEvent()
        {
            Console.WriteLine("Event Started!!!");
        }
    }
}
