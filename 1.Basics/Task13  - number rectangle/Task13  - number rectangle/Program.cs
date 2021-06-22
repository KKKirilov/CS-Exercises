using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Task13 - Write a C# program that takes a number as input and then displays a rectangle of 
3 columns wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5 
Expected Output:
555 
5 5
5 5 
5 5 
555
*/
namespace Task13____number_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int Num = int.Parse(Console.ReadLine());

            Console.WriteLine(" {0} {0} {0}",Num);
            Console.WriteLine("{0}     {0}",Num);
            Console.WriteLine("{0}     {0}", Num);
            Console.WriteLine("{0}     {0}", Num);
            Console.WriteLine(" {0} {0} {0}", Num);
            Console.ReadKey();

        }
    }
}
