# CSharpProgram. test
CSharp Program
# <h1>1.FizzBuzz</h1>
```
using System;
namespace CSharpAssesment
{
	public class Program
	{
		public static void Main(string [] args)
		{
			 FizzBuzz(16);
		
		}
		public static void FizzBuzz(int n)
		{
			//TODO: Return "Fizz" if divided by 3, "Buzz" if divided by 5
			//"FizzBuzz" if divided by both, else return the number as a string
			for(int i=1;i<= n; i++)
			{
				if(i % 3 == 0 )
				{
					Console.WriteLine("Fizz");
				}
				else if(i % 5 == 0 )
				{
					Console.WriteLine("Buzz");
				}
				else if(i % 3 ==0 && i % 5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		
		}
	}
}
 ```
