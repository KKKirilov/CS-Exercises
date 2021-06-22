using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
 */
namespace Task6___multiplication_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int First = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int Second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int Third = int.Parse(Console.ReadLine());

            int Sum = First * Second * Third;

            Console.WriteLine("{0}*{1}*{2}={3}", First, Second, Third, Sum);
            Console.ReadKey();
        }
    }
}
