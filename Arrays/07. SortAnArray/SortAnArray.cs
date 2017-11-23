/*Sorting an array means to arrange its elements in increasing order.
  Write a program to sort an array. Use the "selection sort" algorithm: 
  Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/

using System;

class SortAnArray
{
    static void Main()
    {
        int[] array = { 64, 25, 12, 22, 11, 14, 1, 285, 3 };
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
            }
        }
        foreach (int arrays in array)
        {
            Console.Write(arrays + " ");
        }  
    }
}

