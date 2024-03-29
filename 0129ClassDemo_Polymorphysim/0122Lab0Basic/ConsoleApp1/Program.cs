﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;



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

            //take to input from the user for the second number
            Console.WriteLine("Please enter the second number:");
            double highNumber = Convert.ToDouble(Console.ReadLine());

            //loop until the input number is greater than the first number
            while (highNumber < lowNumber)
                {
                Console.WriteLine("Please enter the second number which is greater the first number:");
                 highNumber = Convert.ToInt32(Console.ReadLine());
                }

            //calculate the difference between low number and high number
            double difference = highNumber - lowNumber;
            Console.WriteLine($"The difference between {highNumber} and {lowNumber} is {difference}");

            //create a list to store the number between low number and high number
            List <string> result = new List <string>();

            //convert double to int and to store them in the list
            int number1 = Convert.ToInt32(highNumber);
            int number2 = Convert.ToInt32(lowNumber);

            // add number between low number and high number to the list 
            for (int i = number1; i >= number2; i--)
                {
                result.Add(i.ToString());  
                }

            //create a file to store the data
            string filepath = @"D:\SAIT\c#\0122Lab0Basic\numbers.txt";
            File.WriteAllLines(filepath, result);

            //Read the numbers back from the file and print out the sum of the numbers and find prime number
            result = File.ReadAllLines(filepath).ToList();
            int total = 0;

            //use flag to track the boolean when checking prime number
            Boolean flag = true;
            //create a stringh to hold all prime numbers
            string primeNum = "";
            foreach (string line in result)
                {
                int eachLine = Convert.ToInt32(line);
                total += eachLine;
                //strat from 4 because 1, 2, 3 are prime numbers
                if (eachLine > 3)
                    {
                    // find the prime number
                for (int i = 2; i < eachLine; i++)
                        {
                        if (eachLine % i == 0)
                            {
                            flag = false;
                            break;
                            }
                        else { 
                            flag = true;
                            

                            }
                        }
                    }
                else 
                    {
                    flag = true;
                    }

                if (flag)
                   {
                    primeNum += line + " ";
                    }
                    
                }

            Console.WriteLine($"The total number in the list is {total}");
            Console.WriteLine($"The prime numbers are: {primeNum}");



            Console.ReadLine();



            }
        }
    }
