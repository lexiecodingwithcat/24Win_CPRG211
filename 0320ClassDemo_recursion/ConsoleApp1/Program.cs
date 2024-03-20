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
            int number = 5;
            int f = Fact(number);
            Console.WriteLine(f);
            Console.ReadLine();

            }
        static int Fact(int number)
            {
            if(number == 0)
                {
                return 1;
                }
            else
                {
                return number*Fact(number-1);
                }
            }
        }
    }
