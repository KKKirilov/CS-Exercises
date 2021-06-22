using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
task26 - Write a C# program to compute the sum of the first 
500 prime numbers.
Sample Output:
Sum of the first 500 prime numbers:
3682913 
*/

namespace Task26___sum_of_the_first_500_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int counter = 0;

            int num = 2;

            while(counter < 500)
            {

                if (isPrime(num))
                {
                    Console.WriteLine(num);
                    Console.WriteLine(counter);
                    counter++;
                    sum += num;
                }

                num++;

            }

            Console.WriteLine(sum);

        }

        static bool isPrime(int num)
        {
            for (int i = 2 ; i < num; i++)
            {

                if (num % i == 0) return false;

            }

            return true;

        }
    }
}
