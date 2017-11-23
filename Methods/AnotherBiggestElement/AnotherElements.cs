/*Write a method that returns the index of
 the first element in array that is bigger 
 than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiggestElementsOfArray;

namespace AnotherBiggestElement
{
    class AnotherElements
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 1}; 
            
            Console.WriteLine(FindBiggestElement(array));
        }
        static int FindBiggestElement(int[] array)
        {
            int position = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[position] )
                {
                   position = array[position];
                   break;
                }
                else
                {
                    position = -1;
                    break;
                }
                position++;
            }
            return position;
        }
    }
}
