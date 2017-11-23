/*Write a program to calculate n! 
 * for each n in the range [1..100]. 
 * Hint: Implement first a method that
 * multiplies a number represented 
 * as array of digits by given integer number. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            int number = 100;
            BigInteger factorial = 1;
            CalculateFactorial(number, factorial);   
        }

        static void CalculateFactorial(int number, BigInteger factorial)
        {
            for (int i = 1; i < number; i++)
            {
                factorial = factorial * i;
                Console.WriteLine(factorial);
            }
            Console.WriteLine();
            Console.WriteLine("The BIG sum is: {0}", factorial);
        }


        
    }
}
