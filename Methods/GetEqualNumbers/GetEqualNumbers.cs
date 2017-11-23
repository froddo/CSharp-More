/*Write a method that counts how many times given number appears in given array.
 Write a test program to check if the method is working correctly.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbers
{
    class EqualNumbers
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 6, 8, 4, 4 };
            
            GetMax(array);
        }
        static void GetMax(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int number = 1 + i; number < array.Length; number++)
                {
                    if (array[i] == array[number])
                    {
                        counter++;  
                    }
                }
            }
            Console.WriteLine(counter);
        } 
    }
}
