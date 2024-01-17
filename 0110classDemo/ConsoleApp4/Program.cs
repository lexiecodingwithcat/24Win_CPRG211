using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5; int y = 10;
          Console.WriteLine(x++); //incremented by value 1
            Console.WriteLine(x--);//decremented by value 1
            if(x>y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("y is greater than x");
            }
           

            //ternary operators, only if and else, no if-else
            int time = 20;
            string result = (time < 10) ? "Good Morning" : "Good Evening";
            Console.WriteLine(result);
            //by using this can change the output into lines
            Console.ReadLine();
        }
    }
}
