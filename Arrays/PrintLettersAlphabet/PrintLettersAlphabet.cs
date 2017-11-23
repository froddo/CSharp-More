/*Write a program that creates an array containing all letters from the alphabet (A-Z). 
 Read a word from the console and print the index of each of its letters in the array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLettersAlphabet
{
    class PrintLettersAlphabet
    {
        static void Main(string[] args)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string letter = Console.ReadLine();
            char[] alphabet = letter.ToCharArray();
            int counter = 0;
            int temp = 1;
            for (int i = 0; i < alpha.Length; i++, temp++)
            {
                if (alpha[i] == alphabet[counter])
                {
                    Console.WriteLine(temp);
                    counter++;
                }
                if (alphabet.Length == counter)
                {
                    break;
                }
            }
        }
    }
}
