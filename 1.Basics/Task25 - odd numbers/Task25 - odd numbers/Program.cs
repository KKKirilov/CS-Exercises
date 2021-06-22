using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task25 - Write a C# program to print the odd numbers from 1 to 99. 
Prints one number per line.
Sample Output:
Odd numbers from 1 to 99. 
Prints one number per line.
1 
3 
5 
7 
9 
...
95
97 
99 
*/
namespace Task25___odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The odd numbers from 1 to 100");
            for (int i = 1; i < 100; i += 2)
            {
                
                Console.WriteLine(i);
             
            }
            Console.ReadLine();
        }
    }
}
