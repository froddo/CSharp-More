/*Write a method that adds two polynomials. 
 * Represent them as arrays of their 
 * coefficients as in the example below:
    x2 + 5 = 1x2 + 0x + 5 --> 501
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPolynomials
{
    class Polynomials
    {
        static void Main(string[] args)
        {
            int[] firstPoly = { 1, 2, 2 };
            int[] secondPoly = { 4, 2, 3 };
            Console.Write("The first polinomial is -->    ");
            PrintPoly(firstPoly, secondPoly);
            AdditionPoly(firstPoly, secondPoly);
        }
        static void PrintPoly(int[] firstPoly, int[] secondPoly)
        {
            for (int i = firstPoly.Length - 1 ; i >= 0; i--)
            {
                if (firstPoly[i] != 0 && i != 0)
                {
                    Console.Write("{1}x^{0} + ", i, firstPoly[i]);
                }
                else
                {
                    Console.Write("{0}", firstPoly[i]);
                }  
            }
            Console.WriteLine("\n");
            if (firstPoly != secondPoly)
            {
                Console.Write("The second polinomial is -->    ");
                firstPoly = secondPoly;
                PrintPoly(firstPoly, secondPoly);
            }
        }
        static void AdditionPoly(int[] firstPoly, int[] secondPoly)
        { 
           List<int> sumPoly = new List<int>();
            Console.Write("The addition of polinomial is -->   ");
            for (int i = firstPoly.Length - 1; i >= 0; i--)
            {
                for (int j = secondPoly.Length - 1; j >= 0; j--, i--)
                {
                    if (firstPoly[i] != 0 && secondPoly[j] != 0)
                    {
                        sumPoly.Add(firstPoly[i] + secondPoly[j]);
                    }
                }
            }
            sumPoly.Reverse();
            for (int i = sumPoly.Count - 1; i >= 0; i--)
            {
                if (sumPoly[i] != 0 && i != 0)
                {
                    Console.Write("{1}x^{0} + ", i, sumPoly[i]);
                }
                else
                {
                    if (sumPoly[i] == 0)
                    {
                        continue;
                    }
                    Console.Write("{0}", sumPoly[i]);
                }  
            }
            Console.WriteLine();
        }
    }
}
