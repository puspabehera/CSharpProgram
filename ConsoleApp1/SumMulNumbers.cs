using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    //C# Program to Find the Sum of All the Multiples of 3 and 5

    //    Steps:
    //Take start and end of the range from the user.
    //Loop from start to end.
    //For each number, check if it’s divisible by 3 or 5.
    //If yes → add it to a running total (sum).
    //Print the final sum.
    public class SumMulNumbers
    {
        public static void SumEvaluate()
        {
            Console.WriteLine("Enter Starting range Number:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ending range Number:");
            int end = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                if(i % 3 ==0 || i % 5== 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Sum of multiples of 3 or 5 between {start} and {end} = {sum}");

        }
    }
}
