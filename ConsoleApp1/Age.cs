using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Age
    {// test demo test
        //Age Category → Take age input and decide (Child, Teen, Adult, Senior)
        public static void AgeRange()
        {
            
            Console.WriteLine("Enter Your Age:");
            int age = int.Parse(Console.ReadLine());

            if(age < 0)
            {
                Console.WriteLine("Invalid Age!");
            }
            else if(age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if(age <= 17)
            {
                Console.WriteLine("Teenager");
            }
            else if(age <= 59)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior Cetizion");
                    
            }
        }
    }
}
