/*Modify your last program and 
 try to make it work for any number type, 
 not just integer (e.g. decimal, float, byte, etc.). 
 Use generic method (read in Internet about generic methods in C#).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyNumberType
{
    class AnyObjectType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The min number of all parameters is: {0} ", FindMin(2, 6, 1, -3, 18, 4, 3, 8, -8.2));
            Console.WriteLine("The max number of all parameters is: {0} ", FindMax(2, 6, 1, -3, 18.4, 4, 3, 8, -8));
            Console.WriteLine("The average number of all parameters is: {0} ", FindAverage(2, 6.1, 1, -3, 18, 4.2, 3, 8, -8));
            Console.WriteLine("The sum number of all parameters is: {0} ", FindSum(2, 6, 1, -3, 18.6843f, 4, 3.7f, 8, -8));
            Console.WriteLine("The product number of all parameters is: {0} ", FindProduct(2, 6.5, 1, -3, 18, 4.8, 3, 8, -8));
        }
        static T FindMin<T>(params T[] elements)
        {
            dynamic min = 0;
            foreach (var item in elements)
            {
                if (item < min)
                {
                    min = item; 
                }
            }
            return min;
        }
        static T FindMax<T>(params T[] elements)
        {
            dynamic max = 0;
            foreach (var item in elements)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static decimal FindAverage(params double[] elements)
        {
            int count = 0;
            decimal average = 0m;
            foreach (var item in elements)
            {
                average += (decimal)item;
                count++;
            }
            average /= count;
            return average;
        }
        static float FindSum(params float[] elements)
        {
            float sum = 0f;
            foreach (var item in elements)
            {
                sum += item;
            }
            return sum;
        }
        static double FindProduct(params double[] elements)
        {
            double product = 1;
            foreach (var item in elements)
            {
                product *= item; 
            }
            return product;
        }
    
    }
}
