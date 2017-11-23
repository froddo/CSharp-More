/*Write a method GetMax() with two parameters that returns the bigger of two integers.
 Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int maxNumber = 10;
            
            GetBiggestNumber(number, maxNumber);
            
            Console.WriteLine("Please enter three integer numbers");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            
            int[] getMaxNumber =  {numberOne, numberTwo, numberThree};                       // ---> Another method to get max number
            Console.WriteLine("The biggest of three numbers is {0} ", getMaxNumber.Max());   // ---> Another method to get max number
            
            GetMax(numberOne, numberTwo, numberThree);
            
        }
        static void GetBiggestNumber(int number, int maxNumber)
        {
            
            if (number > maxNumber)
            {
               
                Console.WriteLine("The biggest of two integer numbers is: {0}", number);
            }
            else if (number < maxNumber)
            {
                
                Console.WriteLine("The biggest of two integer numbers is: {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("The two integers number are equal");
                
            }
            
        }
        static void GetMax(int numberOne, int numberTwo, int numberThree)
        {
            if (numberOne > numberTwo && numberOne > numberThree)
            {
                Console.WriteLine("The biggest of three integer numbers is: {0}", numberOne);
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                Console.WriteLine("The biggest of three integer numbers is: {0}", numberTwo);
            }
            else if (numberThree > numberOne && numberThree > numberTwo)
            {
                Console.WriteLine("The biggest of three integer numbers is: {0}", numberThree);
            }
            else
            {
                Console.WriteLine("The three integers number are equal");
            }

            
        }
    }
}
