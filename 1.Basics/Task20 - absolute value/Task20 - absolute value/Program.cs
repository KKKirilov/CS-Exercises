using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task20 - Write a C# program to get the absolute value of the difference between two given numbers. 
Return double the absolute value of the difference if the first number is greater than second number.
*/

namespace Task20___absolute_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of the two numbers is: {0}",result(Num1, Num2));
            Console.ReadKey();
        }
        

        public static int result(int a , int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            return a - b;
        }
    }
        
}
