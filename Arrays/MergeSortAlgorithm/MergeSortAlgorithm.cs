/* Write a program that sorts an array of 
  integers using the merge sort algorithm 
  (find it in Wikipedia).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortAlgorithm
{
    class MergeSortAlgorithm
    {
        static void Main()
        {
            
            int[] array = { 8, 11, 1, 4, 2, 3, 7, 5, 9 };
            int[] arrayLeft = new int[array.Length / 2];
            int[] arrayRight = new int[array.Length - arrayLeft.Length];
            
            ArraySort(array, arrayLeft, arrayRight);
            MergeSort(arrayLeft, arrayRight);
        }

        public static void ArraySort(int[] array, int[] arrayLeft, int[] arrayRight)
        {
            int count = 0;
            for (int i = 0; i < arrayLeft.Length; i++)
            {
                arrayLeft[i] = array[i];
            }
            for (int j = arrayLeft.Length; j < array.Length; j++)
            {
                arrayRight[count] = array[j];
                count++;
            }
        }
        static void MergeSort(int[] arrayLeft, int[] arrayRight)
        {
            int[] left = new int[arrayLeft.Length];
            int[] right = new int[arrayRight.Length];
            int temp = 1;
            int count = 0;
            if (left.Length != right.Length)
            {
                arrayRight = arrayLeft;
                left = right;
            }
            for ( count = 0; count < arrayLeft.Length; count++)
            {
                if (arrayLeft.Length % 2 == 1 && count > temp)
                {
                     left[count] = arrayLeft[count];
                    break;
                }
                else if (arrayLeft[count] > arrayLeft[temp])
                {
                    left[count] = arrayLeft[temp];
                    left[temp] = arrayLeft[count];
                }
                else if (arrayLeft[count] < arrayLeft[temp])
                {
                    left[count] = arrayLeft[count];
                    left[temp] = arrayLeft[temp];
                }
                count = temp;
                if (arrayLeft.Length % 2 == 1)
                {
                    temp = arrayLeft.Length / 2;
                    temp++;
                }
                else
                {
                    temp = arrayLeft.Length - 1;
                }
            }
           
             MergeSort(arrayRight, arrayLeft);
            
            
            Merge(left, right, arrayRight, arrayLeft);
        }
        static void Merge(int[] left, int[] right, int[] arrayRight, int[] arrayLeft ) 
        {
            int[] arrLeft = left;
            
            
            MergeSort(right, arrayRight);
        }
    }
}
