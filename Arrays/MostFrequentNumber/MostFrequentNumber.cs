/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/

using System;

class MostFrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int start = 1;
        int end = 1;
        int sum = 0;
        int maxSum = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 1 + i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    sum = array[i];
                    start++;
                }
                if (start > end)
                {
                    maxSum = sum;
                    end = start;
                }
            }
            start = 1;
        }

        Console.WriteLine("The most frequend number is {0}  --> {1} times", maxSum, end);
    }
}

