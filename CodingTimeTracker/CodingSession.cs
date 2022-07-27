using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTimeTracker
{
    public class CodingSession
    {
        public CodingSession(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            Duration = CalculateTime(startTime, endTime);
        }

        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        private TimeSpan CalculateTime(DateTime startTime, DateTime endTime)
        {
            TimeSpan duration = endTime - startTime;
            return duration;
        }
    }

}
