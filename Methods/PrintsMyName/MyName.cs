/*Write a method that asks the user for his name and prints “Hello, <name>” 
 (for example, “Hello, Peter!”). Write a program to test this method.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsMyName
{
    public class Name
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = "Pesho Peshev";
            PrintMyName(name);
        }
        public static string PrintMyName(string name)
        {
            Console.WriteLine("Hallo," + " " + name + "!");
            return name;
        }
        
    }
}
