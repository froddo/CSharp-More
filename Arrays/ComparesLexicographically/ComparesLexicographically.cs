/*Write a program that compares two char arrays lexicographically
 (letter by letter).*/

using System;
using System.Linq;

class ComparesLexicographically
{
    static void Main()
    {

        char[] firstArray = { 'a', 'b', 'c', 'd', 'e', 'j', 'h' };

        char[] secondArray = { 'a', 'b', 'c', 'd', 'e', 'j', 'k' };



        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("The second array is first by letter [{0}]", i);
                    break;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is first by letter [{0}]", i);
                    break;
                }
            }
        }
        bool areEqual = Enumerable.SequenceEqual(firstArray, secondArray);

        if (areEqual)
        {
            Console.WriteLine("The two arrays are equal by letter");
        }
    }  
}
