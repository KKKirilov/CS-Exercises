using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task16 - Write a C# program to create a new string from a given string where
the first and last characters will change their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP 
x
*/

namespace Task16___char_positions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            Console.WriteLine(first_last(str));

            Console.WriteLine("pre-entered strings");
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
            Console.ReadKey();
        }
        
        public static string first_last(string ustr ) //New method
        {
            return ustr.Length > 1 //gets the lenght of the string
            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
            //takes the last char------------+takes the middle---------------------+takes the first char--if the string is to small it returns the same string
        }
        
        
    }
}
