using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //C# Program to Print All the Multiples of 17 which are Less than 100
    public class MulOf17
    {
        public static void MultiSeventeen()
        {
            Console.WriteLine("Multiples of 17 less than 100 are:");

       for(int i =17; i< 100; i+= 17)
            {
                Console.WriteLine(i);
            }
        }
    }
}
