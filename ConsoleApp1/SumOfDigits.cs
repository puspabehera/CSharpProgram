using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SumOfDigits
    {
        // C# Program to Find Sum of Digits of a Number
        public static void DigitsNum()
        {

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0, digit;

            while (num > 0)
            {
                digit = num % 10;   // get last digit
                sum += digit;       // add digit to sum
                num = num / 10;     // remove last digit
            }

            Console.WriteLine("Sum of digits: " + sum);


        }
    }
}
