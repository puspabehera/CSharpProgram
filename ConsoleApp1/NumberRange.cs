using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumberRange
    {
        //C# Program to Print Odd Numbers in a Given Range
        public static void Numbers()
        {
            Console.WriteLine("Enter Starting Number!");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ending Number!");
            int end = int.Parse(Console.ReadLine());

            for(int i = start; i<=end; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"odd number between {start} to {end}");

        }
    }
}
