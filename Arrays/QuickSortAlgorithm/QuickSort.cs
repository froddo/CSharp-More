/*Write a program that sorts an array of 
 strings using the quick sort algorithm 
 (find it in Wikipedia).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAlgorithm
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] ollArray = { 5, 3, 2, 8, 7, 6, 1, 9, 4};
            int counter = 0;
            SortOllElements(ollArray, counter);
            
        }

        private static void SortOllElements(int[] ollArray, int counter)
        {
            int[] addOllElements = new int[ollArray.Length];
           
           

            for (int i = 0; i < ollArray.Length - 1; i++)
            {
                if (ollArray[0] > ollArray[i + 1])
                {
                    addOllElements[counter] = (ollArray[i + 1]);
                    counter++;
                }

            }
            addOllElements[counter] = ollArray[0];
            int[] copyArray = addOllElements;
            SortOllElements(copyArray, counter);

            SortLeftArray(addOllElements);
        }

        static void SortLeftArray(int[] addOllElements)
        {
            int counter = 0;
            int[] arrleft= new int[addOllElements.Length];
            arrleft[0] = addOllElements[0];

            for (int i = 0; i < addOllElements.Length; i++)
            {
                if (arrleft[0] > addOllElements[i + 1])
                {
                    addOllElements[i] = addOllElements[i + 1];
                }
            }
        }
    }
}
