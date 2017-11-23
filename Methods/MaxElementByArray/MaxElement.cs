/*Write a method that return the maximal element
 * in a portion of array of integers starting at 
 * given index. Using it write another method 
 * that sorts an array in ascending / descending order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementByArray
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 2, 9, 3, 7, 5, 12, 2, 4, 1, 45}; //---> Take part of elements 3, 7, 5, 12
            TakePartOfElement(array);
            Console.WriteLine("The maximum element by all array is {0}", array.Max());
        }
        static void TakePartOfElement(int[] array)
        {
            int[] partArray = new int[(array.Length / 2) / 2];
            SortPartArray(partArray, array);
        }
        static void SortPartArray(int[] pastArray, int[] array)
        {
            int[] partElements = new int [pastArray.Length + 1];
            for (int i = pastArray.Length + 1, count= 0; i < array.Length - pastArray.Length - 1; i++, count++)
            {
                partElements[count] = array[i];
            }
            Console.Write("The part by all sort array is -->");
            Array.Sort(partElements);
            PrintMaxElement(partElements);
        }
        static void PrintMaxElement(int[] partElements)
        {
            int max = 1;
            int maximumElement = 0;
            for (int i = 0; i < partElements.Length; i++)
            {               
                if (partElements.Length == max)
                {
                    Console.Write(" " + partElements[i]);
                    
                    break;
                }
                if (partElements[i] < partElements[max])
                {
                    maximumElement = partElements[max];
                    max++;
                }
                Console.Write(" " + partElements[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("The maximum element by part of array is {0}", maximumElement);
        }


        
    }
}
