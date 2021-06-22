using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task24 - Write a C# program to find the longest word in a string.
Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
Sample Output:
following
*/

namespace Task24___longest_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
         
            string largest = "";
            string[] array = str.Split(' ');

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i].Length > largest.Length)
                {
                    largest = array[i];
                }

            }

            Console.WriteLine("Largest word is: " + largest);
        }
    }
}