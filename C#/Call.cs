using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Call
    {
        // Ch 14 No. 15
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }

        public Call(DateTime date, DateTime startTime, TimeSpan duration)
        {
            Date = date;
            StartTime = startTime;
            Duration = duration;
        }
    }
}
