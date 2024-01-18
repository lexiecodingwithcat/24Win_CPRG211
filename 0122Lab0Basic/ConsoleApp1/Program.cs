using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;


namespace ConsoleApp1
    {
    class Program
        {
        static void Main(string[] args)
            {
            //take input from user
            Console.WriteLine("Please enter the first number(greater than 0):");
            double lowNumber = Convert.ToDouble(Console.ReadLine());

            while (lowNumber < 0)
                {
                Console.WriteLine("The number you input is less than 0. Please enter a number greater than 0 :");
                lowNumber = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Please enter the second number:");
            double highNumber = Convert.ToDouble(Console.ReadLine());
            while (highNumber < lowNumber)
                {
                Console.WriteLine("Please enter the second number which is greater the first number:");
                 highNumber = Convert.ToInt32(Console.ReadLine());
                }
            double difference = highNumber - lowNumber;
            //create a list 
            List <string> result = new List <string>();
            for (double i = highNumber; i >= lowNumber; i-=0.1)
                {
          //learned this from chatGPT because using double will have many float numbers after dot
          //such as 15.6999999999
            i = Math.Round(i,1);
                // add number between low number and high number to the list 
                result.Add(i.ToString());
                Console.WriteLine(i);
                }
            string filepath = @"D:\SAIT\c#\0122Lab0Basic\numbers.txt";
            File.AppendAllLines(filepath, result);

            //Read the numbers back from the file and print out the sum of the numbers.
            result = File.ReadAllLines(filepath).ToList();
            double total = 0;
            foreach (string line in result)
                {
                double number = Convert.ToDouble(line);
                total += number;
                }
            Console.WriteLine(total);


            Console.ReadLine();



            }
        }
    }
