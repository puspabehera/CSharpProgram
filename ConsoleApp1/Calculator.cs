using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator
    {
        //C# Program to Calculate the Sum, Multiplication, Division and Subtraction of Two Numbers
        public static void calNum()
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            double div = (double)num1 / num2;

            Console.WriteLine($" sum : {sum}");
            Console.WriteLine($" sub : {sub}");
            Console.WriteLine($" mul : {mul}");
            Console.WriteLine($" div : {div}");
        }
    }
}
