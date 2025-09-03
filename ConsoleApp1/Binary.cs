using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Binary
    {
        //C# Program to Find the Sum of Two Binary Numbers
        public static void SumOfBinary()
        {
            Console.WriteLine("Enter a binary1 number: ");
            string b1 = Console.ReadLine();

            Console.WriteLine("Enter a binary2 number: ");
            string b2 = Console.ReadLine();

            //convert binary string to integer
            int num1 = Convert.ToInt32(b1,2);
            int num2 =Convert.ToInt32(b2,2);

            int sum = num1 + num2;

            Console.WriteLine("num : = " + Convert.ToString(sum, 2));

        }
    }
}
