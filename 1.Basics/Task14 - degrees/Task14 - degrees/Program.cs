using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86

kelvin = celsius + 273 
fahrenheit = celsius x 18 / 10 + 32
*/

namespace Task14___degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of celsius: ");
            int cel = Convert.ToInt32(Console.ReadLine());

            int Kel = cel + 273;
            int Far = cel * 18 / 10 + 32;

            Console.WriteLine("Kelvin = {0}", Kel);
            Console.WriteLine("Fahrenheit = {0}", Far);
            Console.ReadKey();
        }
    }
}
