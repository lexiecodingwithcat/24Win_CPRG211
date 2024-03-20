using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number m:");
            double m = Convert.ToDouble(Console.ReadLine());
            double result = CalculateSum(n, m);
            Console.WriteLine(result);

            Console.WriteLine("Division");
            Console.WriteLine("Enter your number:");
            double a = Convert.ToDouble(Console.ReadLine());
            int total = CalculateDivide(a,0);
            Console.WriteLine(total);


            Console.ReadLine();
            }
        static double CalculateSum(double numN, double numM)
            {
            if (numN == numM)
                {
                return numN;
                }
            else if (numN < numM)
                {
                return (numN + CalculateSum(numN + 1, numM));
                }
            else
                {
                return (numN + CalculateSum(numN - 1, numM));
                }
            }

        static int CalculateDivide(double number, int count)
            {
            if (number % 2 == 0)
                {
                count++;
                return CalculateDivide(number / 2, count);
                }
            else
                {
                return count;
                }
            }
        }
    }
