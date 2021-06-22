using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Task11- Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
Test Data:
Enter your age - 25
Expected Output:
You look older than 25
 */

namespace Task11___you_look_older
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you???");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older than {0}", age);
            Console.ReadKey();
        }
    }
}
