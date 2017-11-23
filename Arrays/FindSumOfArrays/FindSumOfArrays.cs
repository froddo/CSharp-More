/*Write a program that finds in given array of integers a sequence of given sum S (if present).
  Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 */

using System;
using System.Collections.Generic;
using System.Linq;

class FindSumOfArrays
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int number = 11;
        int counter = 1;
        int sum = 0;
        int maxSum = 0;
        int index;
        List<int> fillArray = new List<int>();
       
        for (index = 0; index < array.Length; index++, counter++)
        {
            if (array.Length == counter)
            {
                break;
            }
            sum = array[index] + array[counter];
            for (int j = counter; j < array.Length; )
            {
                if (sum == number)
                {
                    for (int i = index; i <= j; i++)
                    {
                        
                        sum = array[i];
                        fillArray.Add(sum);
                        Console.Write("{0}  ", sum);                       
                    }
                    Console.WriteLine();
                    Console.WriteLine("The sum is --> {0}", number);
                    break;
                }
                if (sum > number)
                {
                    break ;
                }
                else 
                {
                    j++;
                    if (array.Length == j)
                    {
                        break;
                    }
                    maxSum = sum + array[j];
                    sum = maxSum;
                }
            }
            
        }
        int sameNumber = fillArray.Sum();
        if (number != sameNumber && number > sameNumber)
        {
            Console.WriteLine("No amount found in sequence! ");
        }
    }
}
