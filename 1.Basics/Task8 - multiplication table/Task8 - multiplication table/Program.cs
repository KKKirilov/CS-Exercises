using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a C# Sharp program that takes a number as input and print its multiplication table.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10 
5 * 3 = 15
....
5 * 10 = 50
*/

namespace Task8___multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            //we are on basics, taht means no for loops
            
            Console.WriteLine("Enter a number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Result = 0;

            Result = Num * 0;
            Console.WriteLine("{0} * {1} = {2}",Num , 0 , Result); //I dont like how we use the variable Result every time

            Result = Num * 1;
            Console.WriteLine("{0} * {1} = {2}", Num, 1, Result);

            Result = Num * 2;
            Console.WriteLine("{0} * {1} = {2}", Num, 2, Result);

            Result = Num * 3;
            Console.WriteLine("{0} * {1} = {2}", Num, 3, Result);

            Result = Num * 4;
            Console.WriteLine("{0} * {1} = {2}", Num, 4, Result);

            Result = Num * 5;
            Console.WriteLine("{0} * {1} = {2}", Num, 5, Result);

            Result = Num * 6;
            Console.WriteLine("{0} * {1} = {2}", Num, 6, Result);

            Result = Num * 7;
            Console.WriteLine("{0} * {1} = {2}", Num, 7, Result);

            Result = Num * 8;
            Console.WriteLine("{0} * {1} = {2}", Num, 8, Result);

            Result = Num * 9;
            Console.WriteLine("{0} * {1} = {2}", Num, 9, Result);

            Result = Num * 10;
            Console.WriteLine("{0} * {1} = {2}", Num, 10, Result);
            Console.ReadKey();
        }
    }
}
