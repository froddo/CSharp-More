/*Extend the program to support also 
 * subtraction and multiplication of polynomials.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipliplicationPolynomials
{
    class SubtractionPolynomials
    {
        static void Main(string[] args)
        {
            int[] firstPoly = { 1, 2, 2 };
            int[] secondPoly = { 4, 2, 3 };
            Console.Write("The first polinomial is -->    ");
            PrintPoly(firstPoly, secondPoly);
            SubtractionPoly(firstPoly, secondPoly);
            MultiplicationPoly(firstPoly, secondPoly);
        }
        static void PrintPoly(int[] firstPoly, int[] secondPoly)
        {
            for (int i = firstPoly.Length - 1; i >= 0; i--)
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
        static void SubtractionPoly(int[] firstPoly, int[] secondPoly)
        {
            int[] subPoly;
            if (firstPoly.Length >= secondPoly.Length)
            {
                 subPoly = new int[firstPoly.Length];
            }
            else
            {
                 subPoly = new int[secondPoly.Length];
            }
            Console.Write("The subtraction of polinomial is -->   ");
            for (int i = firstPoly.Length - 1; i >= 0; i--)
            {
                for (int j = secondPoly.Length - 1; j >= 0; j--, i--)
                {
                    if (firstPoly[i] != 0 && secondPoly[j] != 0)
                    {
                        subPoly[i] = (firstPoly[i] - secondPoly[j]);
                    }
                }
            }
            for (int i = subPoly.Length - 1; i >= 0; i--)
            {
                if (subPoly[i] != 0 && i != 0)
                {
                    Console.Write("{1}x^{0} ", i, subPoly[i]);
                }
                else
                {
                    if (subPoly[i] == 0)
                    {
                        continue;
                    }
                    Console.Write("{0}", subPoly[i]);
                }
            }
            Console.WriteLine();
        }
        static void MultiplicationPoly(int[] firstPoly, int[] secondPoly)
        {
            int[] result = new int[firstPoly.Length + secondPoly.Length];
            for (int i = firstPoly.Length - 1; i >= 0; i--)
            {
                for (int j = secondPoly.Length - 1; j >= 0; j--)
                {
                    int position = i + j;
                    result[position] += (firstPoly[i] * secondPoly[j]);
                }
            }
            Console.WriteLine();
            Console.Write("The multiplication of polinomial is -->   ");
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (result[i] != 0 && i != 0)
                {
                    Console.Write(" {1}x^{0} +", i, result[i]);
                }
                else
                {
                    if (result[i] == 0)
                    {
                        continue;
                    }
                    Console.Write(" {0}", result[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
