/*Write a program that reads two arrays from the console
 and compares them element by element.*/

using System;

class ComparingArrays
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int arr = int.Parse(Console.ReadLine());
        
        int[] firstArray = new int[arr];
        int[] secondArray = new int[arr];

        Console.WriteLine("Enter the values of the first array");
   
        for (int index = 0; index < firstArray.Length; index++)
        {
            firstArray[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the values of the second array");
        for (int index = 0; index < secondArray.Length; index++)
        {
            secondArray[index] = int.Parse(Console.ReadLine());
        }

        bool symmetric = true;

        for (int i = 0; i < arr; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                symmetric = false;
                break;
            }
        }
        Console.WriteLine("The two arrays are = {0}", symmetric);   
        
    }
}
