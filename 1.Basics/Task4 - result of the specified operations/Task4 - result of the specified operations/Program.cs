using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task4 - Write a C# Sharp program to print the result of the specified operations.
Test data:
-1 + 4 * 6
( 35+ 5 ) % 7
14 + -4 * 6 / 11
2 + 15 / 6 * 1 - 7 % 2
Expected Output:
23
5
12
3
*/

namespace Task4___result_of_the_specified_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-1 + 4 * 6 = {0}", -1 + 4 * 6);
            Console.WriteLine("( 35+ 5 ) % 7 = {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", 14 + -4 * 6 / 11);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);
            Console.ReadKey();
        }
    }
}
