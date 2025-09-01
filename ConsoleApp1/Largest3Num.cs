using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    public class Largest3Num
    {
        //Find Largest of Three Numbers
        public static void Large3Number()
        {
            Console.WriteLine("Enter First Number!");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number!");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Number!");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("First number is largest!");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Second number is largest!");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("Third number is largest!");
            }
            else
            {
                Console.WriteLine("All Numbers are equal!");
            }


        }
    }
}
