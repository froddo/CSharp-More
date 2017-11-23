/*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 Find in the array those K elements that have maximal sum.*/

using System;

class MaximumSumOfElements
{
    static void Main()
    {
        Console.WriteLine("Enter two integers number for K < N: ");
        Console.Write("Enter integer number for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number for K: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter elements of array: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
    }
}
