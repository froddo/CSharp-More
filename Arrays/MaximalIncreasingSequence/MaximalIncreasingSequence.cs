/*Write a program that finds the maximal increasing sequence in an array.
 Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the array lenght: ");
        int arr = int.Parse(Console.ReadLine());

        int[] array = new int[arr];

        Console.WriteLine("Enter the values of the array: ");
        
        int len = 1;
        int bestLen = 0;
        int endIndex = 0;


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    endIndex = j;
                }
                len = 1;
            }

        }
        if (len > bestLen)
        {
            endIndex = array.Length - 1;
            
            for (int i = endIndex - len + 1; i <= endIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        if (len < bestLen)
        {
            for (int i = endIndex - bestLen + 1; i <= endIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
