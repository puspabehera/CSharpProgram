using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LeapYear
    {
        //Question 5: Leap Year Check
        public static void Years()
        {
            Console.WriteLine("Enter a Year!");
            int year = int.Parse(Console.ReadLine());
            //Rules for Leap Year
           //  A year is a leap year if:
            // It is divisible by 4, and
            // (It is not divisible by 100) OR(it is divisible by 400).

            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("This year is LeapYear!");
            }
            else
            {
                Console.WriteLine("This year is not LeapYear!");
            }
        }
    }
}
