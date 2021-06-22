using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Task12 - Write a C# program to that takes a number as input and display it four times in a row 
 (separated by blank spaces), and then four times in the next row, with no separation. You should 
 do it two times: Use Console.Write and then use {0}.
Test Data:
Enter a digit: 25 
Expected Output:
25 25 25 25 
25252525 
25 25 25 25 
25252525
*/


namespace Task12___number_rows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int Num = Convert.ToInt32(Console.ReadLine());

            Console.Write(Num);
            Console.Write(" ");
            Console.Write(Num);
            Console.Write(" ");
            Console.Write(Num);
            Console.Write(" ");
            Console.Write(Num);

            Console.WriteLine();

            Console.Write(Num);
            Console.Write(Num);
            Console.Write(Num);
            Console.Write(Num);

            Console.WriteLine();


            Console.WriteLine("{0} {0} {0} {0}", Num);
            Console.WriteLine("{0}{0}{0}{0}", Num);
            Console.ReadKey();

        }
    }
}
