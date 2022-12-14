using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTimeTracker
{
    public class CodingSessionModel
    {
        public CodingSessionModel(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            Duration = CalculateDuration(startTime, endTime);
        }   
        public CodingSessionModel(int id, DateTime startTime, DateTime endTime)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Duration = CalculateDuration(startTime, endTime);
        }

        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        private TimeSpan CalculateDuration(DateTime startTime, DateTime endTime)
        {
            TimeSpan duration = endTime - startTime;
            return duration;
        }
    }

}
