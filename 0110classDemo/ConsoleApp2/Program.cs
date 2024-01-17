using System;
using System.Runtime.CompilerServices;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //typecasting when you assign a value of one datatype to another
            //implicit- convert from one data type to a larger type size
            //char -> int ->float - >double
            int number = 9;
            double mynumber = number; //asign this number from int to double
            
            //explicit - from large to small (how many bytes they can store in the memory)
            double number2 = 9.78;
            int mynumber2 = (int)number2;
            Console.WriteLine(mynumber);


        
        
        }
    }
}
