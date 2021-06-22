using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task7 - Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying 
and dividing of two numbers which will be entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100 
25 / 4 = 6
*/

namespace Task7___output__of_4_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int First = Convert.ToInt32(Console.ReadLine());  //  we can use Convert instead of Parse (does the same thing)

            Console.WriteLine("Enter the second number: ");
            int Second = Convert.ToInt32(Console.ReadLine());

            int Add = First + Second;
            int Sub = First - Second;
            int Mul = First * Second;
            int Div = First / Second;

            Console.WriteLine("{0}+{1}={2}", First, Second, Add );
            Console.WriteLine("{0}+{1}={2}", First, Second, Sub);
            Console.WriteLine("{0}*{1}={2}", First, Second, Mul);
            Console.WriteLine("{0}/{1}={2}", First, Second, Div);
        }
    }
}
