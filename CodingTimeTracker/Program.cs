using CodingTimeTracker;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Some tests how TimeSpan works.
        //DateTime startTime = DateTime.Parse("2022-10-10 10:00");
        //DateTime endTime = DateTime.Parse("2022-10-10 12:00");
        //CodingSession codingSession = new CodingSession(startTime,endTime);
        //Console.WriteLine(codingSession.StartTime);
        //Console.WriteLine(codingSession.EndTime);
        //Console.WriteLine(codingSession.Duration);
        //TimeSpan duration = codingSession.Duration + codingSession.Duration;
        //Console.WriteLine(duration);
        DBManager dbManager = new DBManager();
    }
}