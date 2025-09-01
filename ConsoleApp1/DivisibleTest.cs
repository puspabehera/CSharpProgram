using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DivisibleTest
    {
       // C# Program to Check if a Number is Divisible by 2
       public static void DivNumber()
        {
            Console.WriteLine("Enter a Number! :");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Divisible by 2");
            }
            else
            {
                Console.WriteLine("Number is not Divisible by 2!");
            }
        }
    }
}
