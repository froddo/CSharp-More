/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;
class MaximalSumInArray
{
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int startIndex = 0;
        int endIndex = 0;
        int sum = 0;
        int bestSum = int.MinValue;

        for (int index = 0; index < array.Length; index++)
        {
            sum = sum + array[index];

            if (array[index] > sum)
            {
                sum = array[index];
                startIndex = index;
            }
            if (sum > bestSum)
            {
                bestSum = sum;
                endIndex = index;
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
