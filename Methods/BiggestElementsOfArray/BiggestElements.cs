/*Write a method that checks if the element at given position in given array 
 of integers is bigger than its two neighbors (when such exist).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BiggestElementsOfArray
{
    class BiggestElements
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 2, 1 };
            List<int> position = new List<int>();

            FindBiggestElement(array, position);
            PrintPosition(position);
           
        }
        static void FindBiggestElement(int[] array, List<int> position)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1 + i, k = j + 1; j < array.Length;)
                {
                    if (array[i] < array[j] && array[j] > array[k])
                    {
                        position.Add(array[j]);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            } 
        }
        static void PrintPosition(List<int> position)
        {
            foreach (var positions in position)
            {
                Console.WriteLine("The position of biggest integer number between two small neighbors is --> {0}", positions);
            }
        }
    }
}
