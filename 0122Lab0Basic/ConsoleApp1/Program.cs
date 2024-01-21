using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace ConsoleApp1
    {
    class Program
        {
        static void Main(string[] args)
            {
            //take input from user
            Console.WriteLine("Please enter the first number(greater than 0):");
            double lowNumber = Convert.ToDouble(Console.ReadLine());
            //loop until the input number is positive 
            while (lowNumber < 0)
                {
                Console.WriteLine("The number you input is less than 0. Please enter a number greater than 0 :");
                lowNumber = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Please enter the second number:");
            double highNumber = Convert.ToDouble(Console.ReadLine());
            //loop until the input number is greater than the first number
            while (highNumber < lowNumber)
                {
                Console.WriteLine("Please enter the second number which is greater the first number:");
                 highNumber = Convert.ToInt32(Console.ReadLine());
                }
            double difference = highNumber - lowNumber;
            Console.WriteLine($"The difference between {highNumber} and {lowNumber} is {difference}");

            //create a list 
            List <string> result = new List <string>();

            //convert double to int 
            int number1 = Convert.ToInt32(highNumber);
            int number2 = Convert.ToInt32(lowNumber);
            for (int i = number1; i >= number2; i--)
                {
        
                // add number between low number and high number to the list 
                result.Add(i.ToString());
               
                }
            string filepath = @"D:\SAIT\c#\0122Lab0Basic\numbers.txt";
            File.WriteAllLines(filepath, result);

            //Read the numbers back from the file and print out the sum of the numbers.
            result = File.ReadAllLines(filepath).ToList();
           int total = 0;
            Boolean flag = true;
            foreach (string line in result)
                {
                int eachLine = Convert.ToInt32(line);
                total += eachLine;
                if (eachLine > 3)
                    {
                    for (int i = 2; i < eachLine; i++)
                        {
                        if (eachLine % i == 0)
                            {
                            flag = false;
                            break;
                            }
                        else { flag = true; }
                        }
                    }
                if (flag)
                    {
                    Console.WriteLine($"{eachLine} is a prime number");
                    }
                else
                    {
                    Console.WriteLine($"{eachLine} is not a prime number");
                    }
                
                    

                }

            Console.WriteLine($"The total number in the list is {total}");




            Console.ReadLine();



            }
        }
    }
