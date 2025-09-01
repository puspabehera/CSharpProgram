using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    public class PositiveNegativeZero
    {
        public static void PoSiZero() 
        {
            //Question 2: Check Positive, Negative, or Zero
            Console.WriteLine("Enter a number:");
           int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is Positive!");
            }
            else if(num < 0)
            {
                Console.WriteLine("Number is Negative!");
            }
            else
            {
                Console.WriteLine("number is zero!");
            }
        }
    }
}
