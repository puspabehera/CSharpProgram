using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Binary2
    {
        //C# Program to Multiply Two Binary Numbers
        public static void MulOfBinary()
        {
            Console.WriteLine("Enter First binary number : ");
            string b1 = Console.ReadLine();

            Console.WriteLine("Enter Second binary number :");
            string b2 = Console.ReadLine();

            int num1 = Convert.ToInt32(b1, 2);
            int num2 = Convert.ToInt32(b2, 2);

            int mul = num1 * num2;

            Console.WriteLine("Multiple : " + Convert.ToString(mul, 2));
        }
    }
}
