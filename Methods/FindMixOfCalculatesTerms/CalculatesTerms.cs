/*Write methods to calculate minimum, maximum, 
 average, sum and product of given set of 
 integer numbers. Use variable number of arguments.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMixOfCalculatesTerms
{
    class CalculatesTerms
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The min number of all parameters is: {0} ", FindMin(2, 6, 1, -3, 18, 4, 3, 8, -8));
            Console.WriteLine("The max number of all parameters is: {0} ", FindMax(2, 6, 1, -3, 18, 4, 3, 8, -8));
            Console.WriteLine("The average number of all parameters is: {0} ", FindAverage(2, 6, 1, -3, 18, 4, 3, 8, -8));
            Console.WriteLine("The sum number of all parameters is: {0} ", FindSum(2, 6, 1, -3, 18, 4, 3, 8, -8));
            Console.WriteLine("The product number of all parameters is: {0} ", FindProduct(2, 6, 1, -3, 18, 4, 3, 8, -8));
        }

        static int FindMin(params int[] elements)
        {
            //int min = elements.Min();----> Another Result
            //return min;
            
            int min = 0;
            foreach (var item in elements)
            {
                if (item < min)
                {
                    min = item; 
                }
            }
            return min;
        }
        static int FindMax(params int[] elements)
        {
            //int max = elements.Max();-----> Another result
            //return max;

            int max = 0;
            foreach (var item in elements)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static int FindAverage(params int[] elements)
        {
            int count = 0;
            int average = 0;
            foreach (var item in elements)
            {
                average += item;
                count++;
            }
            average /= count;
            return average;
        }
        static int FindSum(params int[] elements)
        {
            int sum = 0;
            foreach (var item in elements)
            {
                sum += item;
            }
            return sum;
        }
        static int FindProduct(params int[] elements)
        {
            int product = 1;
            foreach (var item in elements)
            {
                product *= item; 
            }
            return product;
        }
    }
}
