using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //C# Program to Swap Two Numbers
    public class Swap
    {
        public static void SwapNumber() 
        {
            Console.WriteLine("Enter first Number :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before Swapping = num1 : {num1} & num2 : {num2} ");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After Swapping = num1 : {num1} & num2 : {num2}");
        }
  
    } 
}
