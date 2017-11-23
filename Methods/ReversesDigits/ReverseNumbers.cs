/*Write a method that reverses the digits
   of given decimal number. Example: 256  652
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversesDigits
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            int num = 256;
            Reverse(num);
        }
        static void Reverse(int num)
        {
            while (num > 0)
            {
                int number = num % 10;
                int secondNumber = num / 10;
                int reverses = number;
                Console.Write(reverses);
                reverses = secondNumber;
                Console.WriteLine(reverses);
                break;
            } 
        }
    }
}
