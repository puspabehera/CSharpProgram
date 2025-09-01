using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    public class Vowel
    {
        //Question 6: Vowel or Consonant
        public static void VowelLetter()
        {
            Console.WriteLine("Enter a letter!");
            char ch = Console.ReadLine()[0];

            if (!char.IsLetter(ch))
            {
                Console.WriteLine("not a albhabet!");
            }
            else if(ch == 'a' || ch =='e' || ch == 'i' || ch == 'o' ||  ch == 'u' 
                || ch == 'A' || ch == 'E' || ch == 'I' ||  ch == 'O' || ch == 'U')
            {
                Console.WriteLine($"{ch} Letter is vowel!");
            }
            else
            {
                Console.WriteLine($"{ch} Is a consonant!");
            }
            

        }
    }
}
