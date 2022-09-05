using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class UserInput
    {
        public static void Init()
        {
            while (true)
            {
                Console.WriteLine("Type a year:");
                int input = int.Parse(Console.ReadLine());
                var leapYearCalculator = new LeapYear();
                bool isLeapYear = leapYearCalculator.IsLeapYear(input);
                Console.WriteLine(isLeapYear ? "yay" : "nay");
            }
        }
    }
}
