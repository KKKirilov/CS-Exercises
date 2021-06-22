using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10 
Enter the Second number: 15 
Enter the third number: 20 
Enter the four number: 30 

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
*/
namespace Task9___average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int Num1 = Convert.ToInt32(Console.ReadLine()); //Here we can use double for bigger numbers 

            Console.WriteLine("Enter the second number:");
            int Num2 = Convert.ToInt32(Console.ReadLine()); //the syntax is almost the same.

            Console.WriteLine("Enter the third number:");
            int Num3 = Convert.ToInt32(Console.ReadLine()); //We just need to change the variable from int to double

            Console.WriteLine("Enter the fourth number:");
            int Num4 = Convert.ToInt32(Console.ReadLine()); //And make the Convert to Double syntax(Convert.ToDouble)

            int Avg = (Num1 + Num2 + Num3 + Num4) / 4;
            Console.WriteLine("The averige of the four numers equals to: {0}", Avg);
            Console.ReadKey();
        }
    }
}
