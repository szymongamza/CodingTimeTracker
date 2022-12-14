using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTimeTracker
{
    public class ValidationInput
    {
        public string DateTimeInput(string outputText)
        {
            Console.WriteLine($"Input {outputText} with format: yyyy-MM-dd hh:mm");
            var input = Console.ReadLine();
            while (!DateTime.TryParse(input,out _))
            {
                Console.WriteLine("Invalid Date!");
                input = Console.ReadLine();
            }
            return input;
        }
        public int IntInput(string outputText)
        {
            Console.WriteLine($"{outputText}");
            var number = Console.ReadLine();
            while (!Int32.TryParse(number, out _) || Convert.ToInt32(number) < 0)
            {
                Console.WriteLine("Invalid number!");
                number = Console.ReadLine();
            }
            int returnNumber = Convert.ToInt32(number);
            return returnNumber;
        }
    }
}
