/*Write a method that adds two positive integer 
 * numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbersFromArray
{
    class AddNumbers
    {
        static void Main(string[] args)
        {
            int[]  firstArr = { 9, 9, 9, 2 };
            int[] secondArr = { 9, 9, 9, 9, 9, 9 };
            SumArrays(firstArr, secondArr);
        }

        static void SumArrays(int[] firstArr, int[] secondArr)
        {
            if (firstArr.Length > secondArr.Length)
            {
                int[] array = secondArr;
                secondArr = firstArr;
                firstArr = array;
            }
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            int[] maxLength = new int[secondArr.Length + 1];
            if (firstArr.Length <= secondArr.Length)
            {
                for (int i = 0; i < maxLength.Length; i++)
                {
                    if (firstArr.Length == i)
                    {
                        while (secondArr.Length > i)
                        {
                            maxLength[i] = (secondArr[i] + 1) % 10 ;
                            i++;
                        }
                        maxLength[i] = 1;
                        break;
                    }
                    else if (i == 0)
                    {
                        maxLength[i] = (firstArr[i] + secondArr[i]) % 10;
                    }
                    else if (i > 0)
                    {
                        maxLength[i] = ((firstArr[i] + secondArr[i]) % 10) + ((firstArr[i] + secondArr[i]) / 10);
                    }
                }
            }
            Console.Write("The sum of elements by two arrays are: ");
            ReverseArray(maxLength);
        }
        static void ReverseArray(int[] arrayLength)
        {
            Array.Reverse(arrayLength);
            foreach (var revers in arrayLength)
            {
                Console.Write(revers);
            }
            Console.WriteLine();
        }
        
    }
}
