using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task19 - Write a C# program to compute the sum of two given integers, 
if two values are equal then return the triple of their sum.
*/

namespace Task19___sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            if (Num1 == Num2)
            {
                Console.WriteLine("The triple of the sum: {0}",(Num1 + Num2) * 3);
            }
            else
            {
                Console.WriteLine("The sum of the two numbers is: {0}",Num1+Num2);
            }
            Console.ReadKey();

            /*
             
            It was made this way in the site, but it works both ways

                    static void Main(string[] args)
                {
                    Console.WriteLine(SumTriple(2,2));
                    Console.WriteLine(SumTriple(12,10));
                    Console.WriteLine(SumTriple(-5,2));          
                }
                    public static int SumTriple(int a, int b)
                {
                    return a == b ? (a + b)*3 : a + b;
                }
            */

        }
    }
}
