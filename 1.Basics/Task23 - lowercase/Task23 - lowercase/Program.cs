using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task23 - Write a C# program to convert a given string into lowercase.
Sample Output:
write a c# sharp program to display the following pattern using the alphabet.
*/
namespace Task23___lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            Console.WriteLine(Lowercase(str));
            Console.ReadKey();
        }
        

        public static string Lowercase(string ustr)
        {
            return ustr.ToLower();
        }
    }
}
