using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7
Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
*/

namespace Task10___input_and_print_output
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Enter the first (x) number: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second (y) number: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third (z) number: ");
            double Num3 = Convert.ToDouble(Console.ReadLine());

            double Sum1 = (Num1 + Num2) * Num3;
            Console.WriteLine("({0} + {1}) * {2} = {3}", Num1, Num2, Num3, Sum1);

            double Sum2 = Num1 * Num2 + Num2 * Num3;
            Console.WriteLine("{0} * {1} + {2} * {3} = {4}", Num1, Num2, Num2, Num3, Sum2);
            Console.ReadKey();


            
        }
    }

}
    

