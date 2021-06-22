using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Task17 - Write a C# program to create a new string from a given string (length 1 or more )
with the first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog. 
TThe quick brown fox jumps over the lazy dog.T
*/


namespace Task17___new_string
{
    class Program
    {
        //thought this would be witj a method like task16 but NO....
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s+str+s);
            }
            Console.ReadKey();
        }

    }
}
