/*Write a program that finds the index of given element in a sorted array
 of integers by using the binary search algorithm (find it in Wikipedia).
*/

using System;

class BinarySearch
{
    static void Main()
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

        int searchNumber = 6;

        int sum = (array.Length - 1) / 2;
        int min = 1;
        int max = array.Length - 1;
        int count = (array.Length - 1) / 2;
        

        if (array[sum] == searchNumber)
        {
            Console.WriteLine(sum);
            return;
        }
        while (array[sum] > searchNumber)
        {
            sum = (sum + min) / 2 - min;
            if (array[sum] == searchNumber)
            {
                Console.WriteLine(sum);
                return;
            }
            while (array[sum] < searchNumber)
            {
                sum = (sum + count) / 2 + min;
                if (array[sum] == searchNumber)
                {
                    Console.WriteLine(sum);
                    return;
                }
                min--;
            }
            
        }
        while (array[sum] < searchNumber)
        {          
             sum = (sum + max) / 2 + min;
             if (array[sum] == searchNumber)
             {
                 Console.WriteLine(sum);
                 return;
             }
             
             while (array[sum] > searchNumber)
             {
                 sum = (count + sum) / 2 - min;
                 if (array[sum] == searchNumber)
                 {
                     Console.WriteLine(sum);
                     return;
                 }
                 min--;
             }
        }
        
    }
}
