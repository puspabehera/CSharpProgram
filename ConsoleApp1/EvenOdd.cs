using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EvenOdd
    {
        //Write a C# program to check if a given number is Even or Odd.
      public static void EvenOrOdd()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("number is even!");
            }
            else
            {
                Console.WriteLine("number is odd!");
            }
        }
        

    }
}
