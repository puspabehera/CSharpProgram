using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class LargestNum
    {
        //Question 3: Find Largest of Two Numbers
        public static void LargeNumber()
        {
            Console.WriteLine("Enter First Number!");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number!");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("First Number is Largest!");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Second Number is Largest!");
            }
            else
            {
                Console.WriteLine("Both are Equal!");
            }



        }
    }
}
