using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task22 - Write a C# program to check if an given 
integer is within 20 of 100 or 200. 
Sample Output:
Input an integer: 
25 
False 
*/

namespace Task22___within_20_of_100_or_200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(result(Num));
            Console.ReadKey();
        }

        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
                return true;
            return false;
            //Cant figure out how does the absolute value works
        }
    }
}
