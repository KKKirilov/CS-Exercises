using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a C# program and compute the sum of the digits of an integer.
*/
namespace Task27___sum_of_the_digits_of_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input  a number (integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }
    }
}
//What is this shit
