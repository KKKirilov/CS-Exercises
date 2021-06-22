using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task15 - Write a C# program remove specified a character from a non-empty string using index of a character.
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource
*/

namespace Task15___remove__a_character
{
    class Program
    {
        //dindn`t know how to do this one.
        static void Main(string[] args)
        {
            //here write w3resource
            //if the string is shorter then 9 chars its an error 
            Console.WriteLine("Enter a string :");
            string Str = Console.ReadLine();

            Console.WriteLine(RemoveChar(Str, 1));
            Console.WriteLine(RemoveChar(Str, 9));
            Console.WriteLine(RemoveChar(Str, 0));
        }
        //basically we make a method that removes a char
        public static string RemoveChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
