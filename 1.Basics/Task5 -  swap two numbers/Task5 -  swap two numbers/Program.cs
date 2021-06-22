using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task5 - Write a C# Sharp program to swap two numbers. 
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output: 
After Swapping :
First Number : 6 
Second Number : 5 
*/

namespace Task5____swap_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int First, Second, temp;

            Console.Write("Enter the first number: ");
            First = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            Second = int.Parse(Console.ReadLine());

            temp = First;
            First = Second;
            Second = temp;

            Console.WriteLine("After swaping the numbers :");
            Console.WriteLine("The first number: {0}", First);
            Console.WriteLine("The second number = {0}" , Second);
            Console.ReadKey();

        }
    }
}
