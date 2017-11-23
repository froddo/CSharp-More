/*Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    a should not be equal to 0
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixOfProgramSolve
{
    class ProgramSolve
    {
        static void Main()
        {
            Console.WriteLine("Please chose different problem to solve tasks! \n");
            Console.WriteLine("Problem reverses numbers, if chose thah press 1! \n");
            Console.WriteLine("Problem calculates average numbers, if chose that press 2! \n");
            Console.WriteLine("Problem solves linear equation, if chose thah press 3! \n");
            Console.WriteLine("If you want to leave all that press 0, it is will exit! \n");
            Console.WriteLine("Please press number 1 - 3! or 0 to exit! \n");
            int problem = int.Parse(Console.ReadLine());
            if (problem == 1)
            {
                Console.WriteLine("Please enter the numbers");
                int revNumber = int.Parse(Console.ReadLine());
                ReverseNumbers(revNumber);
            }
            else if (problem == 2)
            {
                Console.WriteLine("Please enter the numbers");
                decimal aveNum = decimal.Parse(Console.ReadLine());
                AverageNumber(aveNum);
            }
            else if (problem == 3)
            {
                Console.WriteLine("Please enter the number of a > 0: ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number of b > 0: ");
                decimal b = decimal.Parse(Console.ReadLine());
                while (a <= 0 || b <= 0)
                {
                    Console.Clear();
                    Main();
                    return;
                }
                Console.WriteLine("The linear equation x = {0}", LinearEquation(a, b));
            }
            else if (problem == 0)
            {
                System.Environment.Exit(0);
            }
        }
        static void ReverseNumbers(int revNumber)
        {
            List<int> rev = new List<int>();
            while (revNumber != 0)
            {
                int reverse = revNumber % 10;
                rev.Add(reverse);
                revNumber = revNumber / 10;
            }
            Console.Write("The reverses numbers are: ");
            foreach (var item in rev)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void AverageNumber(decimal aveNum)
        {
            List<decimal> ave = new List<decimal>();
            while (aveNum != 0)
            {
                decimal aver = (int)aveNum % 10;
                ave.Add(aver);
                aveNum = (int)aveNum / 10;
            }
            decimal averages = ave.Average();
            Console.Write("The calculates average numbers is: ");
            Console.WriteLine(averages);
        }
        static decimal LinearEquation(decimal a, decimal b)
        {
                //a * x + b = 0;
                //a * x = -b;
                //x = -b / a;
                decimal x =  - (b / a);
                return x;
        }
    }
}
