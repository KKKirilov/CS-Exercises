using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task21 - Write a C# program to check the sum of the two given integers and 
return true if one of the integer is 20 or if their sum is 20.
*/
namespace Task21___20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an integer:");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Num2==20 || Num2 == 20 || (Num1+Num2==20));
            Console.ReadKey();
        }
    }
}
