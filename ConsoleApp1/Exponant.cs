using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exponant
    {
        //C# Program to Perform Multiplication of Exponents of Same Base

        public static void ExponantProgram()
        {
            Console.WriteLine("Enter the base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the First Exponant: ");
            int exp1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Exponant: ");
            int exp2 = int.Parse(Console.ReadLine());

            int FinalExponant = exp1 + exp2;
            double result = Math.Pow(baseNum, FinalExponant);

            Console.WriteLine($"{baseNum}^{exp1} * {baseNum}^{exp2} = {baseNum}^{FinalExponant} = {result}");
        }
    }
}
