using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTimeTracker
{
    public class CodingStopwatch
    {
        InputManager inputManager = new InputManager();
        public void StopWatchMenu()
        {
            Console.WriteLine("Stopwatch - press enter to start.");
            Console.ReadLine();
            DateTime lastTime = DateTime.Now;
            TimeSpan elapsed = TimeSpan.Zero;
            do
            {
                while (!Console.KeyAvailable)
                {
                    elapsed = DateTime.Now - lastTime;
                    Console.WriteLine($"{elapsed}");
                    Console.WriteLine($"You can stop stopwatch with ESC Key.");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            DateTime nowTime = DateTime.Now;
            Console.WriteLine($"Stopwatch stopped. Elapsed time: {lastTime - nowTime}. Press to Y to save time to database. Press N to proceed without saving.");
            var option = Console.ReadKey();
            switch (option.Key)
            {
                case ConsoleKey.Y:
                    {
                        inputManager.InsertData(lastTime, nowTime);
                        break;
                    }
                case ConsoleKey.N:
                    {
                        break;
                    }
            }
        }
    }
}
