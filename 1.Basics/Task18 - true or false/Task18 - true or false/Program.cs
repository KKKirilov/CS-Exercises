using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Tak18 - Write a C# program to check two given integers and return true if
one is negative and one is positive. Go to the editor
Sample Output:
Input first integer:
-5 
Input second integer: 
25 
Check if one is negative and one is positive: 
True 
*/
namespace Task18___true_or_false
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("One is negative, the other is positive:");
            Console.WriteLine((Num1<0 && Num2>0) || (Num1 > 0 && Num2 < 0));
            Console.ReadKey();
        }
    }
}
