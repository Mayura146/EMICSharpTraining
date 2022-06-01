using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithouDIP
{
    internal class Reminder
    {
        public DateTime startTime;
        public string title;
        public string description;
        public void startReminder()
        {
            Console.WriteLine("Reminder Set!!!");
        }
    }
}
