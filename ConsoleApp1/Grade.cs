using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Grade
    {
        //Grade Calculator → Input marks and print grade (A, B, C, D, Fail).
        public static void GradeMarks()
        {
            Console.WriteLine("Enter marks 0 - 100 : ");
            int marks = int.Parse(Console.ReadLine());

            if(marks < 0 || marks > 100)
            {
                Console.WriteLine("Marks is InValid!");
            }
            else if(marks >= 90)
            {
                Console.WriteLine("A Grade");
            }
            else if(marks >= 70)
            {
                Console.WriteLine("B Grade");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("C Grade");
            }
            else if(marks >= 35)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
