/*Write a program that finds the maximal sequence of equal elements in an array.
Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/

using System;

class FindsEqualElements
{
    static void Main()
    {
        Console.Write("Enter the array lenght: ");
        int arr = int.Parse(Console.ReadLine());

        int[] array = new int[arr];
        
        Console.WriteLine("Enter the values of the array: ");
        int len = 1;
        int bestLen = 0;
        int best = 1;
        int bestElement = 0;
        
        for (int i = 0; i < array.Length; i++)
        { 
            array[i] = int.Parse(Console.ReadLine());
        }
            for (int j = 0; j < arr - 1; j++)
            {
                if (array[j] == array[j + 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestElement = array[j];
                        best = array[j + 1];
                    }
                    len = 1;
                }
               
            }
            if (len > bestLen)
            {
                for (int i = 0; i < len; i++)
                {
                    Console.Write(best + " ");
                }
            }
            else if(len < bestLen)
            {
                for (int i = 0; i < bestLen; i++)
                {
                    Console.Write(bestElement + " ");
                }
            }
        
    }
}
