using System;
using System.IO;
using System.Runtime.Remoting.Contexts;


namespace ConsoleApp1
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Please enter the first number(greater than 0):");
            int lowNumber = Convert.ToInt32(Console.ReadLine());
            while (lowNumber < 0)
                {
                Console.WriteLine("The number you input is less than 0. Please enter a number greater than 0 :");
                lowNumber = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Please enter the second number:");
            int highNumber = Convert.ToInt32(Console.ReadLine());
            while (highNumber < lowNumber)
                {
                Console.WriteLine("Please enter the second number which is greater the first number:");
                 highNumber = Convert.ToInt32(Console.ReadLine());
                }
            int difference = highNumber - lowNumber;
            int[] numbers = new int[difference+1];
            int index = 0;
            for (int i = highNumber; i > lowNumber; i--)
                {
                numbers[index] = i;
                //Console.WriteLine(numbers[index]);
                index++;
               
                }



            Console.ReadLine();



            }
        }
    }
